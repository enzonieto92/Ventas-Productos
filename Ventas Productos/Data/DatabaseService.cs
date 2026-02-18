using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ventas_Productos.Domain;

namespace Ventas_Productos.Data
{
    internal class DatabaseService
    {
        private readonly string rutaDb =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_ventas.db");

        private SqliteConnection CrearConexion()
        {
            var conn = new SqliteConnection($"Data Source={rutaDb}");
            conn.Open();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "PRAGMA foreign_keys = ON;";
                cmd.ExecuteNonQuery();
            }

            return conn;
        }

        // ================= PRODUCTOS =================

        public Producto ObtenerProducto(int id)
        {
            using (var conn = CrearConexion())
            {
                string sql = @"SELECT Id, nombre, precio, cod_barras 
                               FROM Productos 
                               WHERE Id = @id";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Producto
                            {
                                Id = Convert.ToInt32(reader.GetValue(0)),
                                Nombre = reader.GetString(1),
                                Precio = Convert.ToDecimal(reader.GetValue(2), CultureInfo.InvariantCulture),
                                CodigoBarras = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void EliminarProducto(int id)
        {
            using (var conn = CrearConexion())
            {
                string sql = @"UPDATE Productos SET Activo = 0 WHERE Id = @id";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Producto desactivado correctamente.");
                    else
                        MessageBox.Show("No se encontró ningún producto con ese Id.");
                }
            }
        }
        public void EditarProducto(Producto producto)
        {
            using (var conn = CrearConexion())
            {
                string sql = "UPDATE Productos SET Nombre = @nombre, Precio = @precio, cod_barras = @cod_barras WHERE Id = @id";
                using (var cmd = new SqliteCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("id", producto.Id);
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre); 
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@cod_barras", producto.CodigoBarras);
                    int filasAfectadas = cmd.ExecuteNonQuery(); 
                    if (filasAfectadas > 0) 
                        MessageBox.Show("Producto editado correctamente.");
                    else MessageBox.Show("No se encontró el producto con ese Id.");
                }
            }
        }
        public List<Producto> ObtenerProductos(string busqueda)
        {
            var productos = new List<Producto>();

            using (var conn = CrearConexion())
            {
                string sql;

                if (string.IsNullOrWhiteSpace(busqueda))
                {
                    sql = @"SELECT Id, nombre, precio, cod_barras 
                        FROM Productos 
                        WHERE activo = 1
                        ORDER BY nombre COLLATE NOCASE ASC;";
                }
                else if (busqueda.All(char.IsLetter))
                {
                    sql = @"SELECT Id, nombre, precio, cod_barras
                        FROM Productos
                        WHERE nombre LIKE '%' || @busqueda || '%'
                        ORDER BY nombre COLLATE NOCASE ASC;";
                }
                else
                {
                    sql = @"
                        SELECT Id, nombre, precio, cod_barras
                        FROM Productos
                        WHERE
                            cod_barras = @busqueda
                            OR (
                                NOT EXISTS (
                                    SELECT 1
                                    FROM Productos
                                    WHERE cod_barras = @busqueda
                                )
                                AND LENGTH(@busqueda) > 3
                                AND cod_barras LIKE SUBSTR(@busqueda, 1, LENGTH(@busqueda) - 3) || '%'
                            )
                        ORDER BY
                            CASE
                                WHEN cod_barras = @busqueda THEN 0
                                ELSE 1
                            END
                        ;";
                }

                using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productos.Add(new Producto
                                {
                                    Id = Convert.ToInt32(reader.GetValue(0)),
                                    Nombre = reader.GetString(1),
                                    Precio = Convert.ToDecimal(reader.GetValue(2), CultureInfo.InvariantCulture),
                                    CodigoBarras = reader.IsDBNull(3) ? null : reader.GetString(3)
                                });
                            }
                        }
                    }
            }

            return productos;
        }

        public List<ProductoStock> ObtenerProductosConStock(string busqueda)
        {
            {
                var productos = new List<ProductoStock>();

                using (var conn = CrearConexion())
                {
                    string sql;

                    if (string.IsNullOrWhiteSpace(busqueda))
                    {
                        sql = @"SELECT 
                                p.Id,
                                p.nombre,
                                p.precio,
                                p.cod_barras,
                                s.cantidad AS stock
                            FROM Productos p
                            INNER JOIN Stock s ON s.IdProducto = p.Id
                            WHERE p.activo = 1 AND s.Cantidad > 0
                            ORDER BY nombre COLLATE NOCASE ASC;";
                    }
                    else if (busqueda.All(char.IsLetter))
                    {
                        sql = @"SELECT
                                p.Id,
                                p.nombre,
                                p.precio,
                                p.cod_barras,
                                s.cantidad AS stock
                            FROM Productos p
                            INNER JOIN Stock s ON s.IdProducto = p.Id
                            WHERE p.nombre LIKE '%' || @busqueda || '%' AND s.Cantidad > 0
                            ORDER BY nombre COLLATE NOCASE ASC;";
                    }
                    else
                    {
                        sql = @"
                                SELECT 
                                    p.Id,
                                    p.nombre,
                                    p.precio,
                                    p.cod_barras,
                                    s.cantidad AS stock
                                FROM Productos p
                                INNER JOIN Stock s ON s.IdProducto = p.Id
                                WHERE
                                (
                                    p.cod_barras = @busqueda
                                )
                                OR
                                (
                                    NOT EXISTS (
                                        SELECT 1 
                                        FROM Productos 
                                        WHERE cod_barras = @busqueda
                                    )
                                    AND LENGTH(@busqueda) > 3
                                    AND p.cod_barras LIKE SUBSTR(@busqueda, 1, LENGTH(@busqueda) - 3) || '%'
                                )
                                AND s.Cantidad > 0
                                ORDER BY
                                CASE
                                    WHEN p.cod_barras = @busqueda THEN 0
                                    ELSE 1
                                END;";
                    }
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productos.Add(new ProductoStock
                                {
                                    Id = Convert.ToInt32(reader.GetValue(0)),
                                    Nombre = reader.GetString(1),
                                    Precio = Convert.ToDecimal(reader.GetValue(2), CultureInfo.InvariantCulture),
                                    CodigoBarras = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Stock = Convert.ToInt32(reader.GetValue(4))
                                });
                            }
                        }
                    }
                }

                return productos;
            }
        }
        public List<ProductoStock> ObtenerStock(string busqueda)
        {
            {
                var productos = new List<ProductoStock>();

                using (var conn = CrearConexion())
                {
                    string sql;

                    if (string.IsNullOrWhiteSpace(busqueda))
                    {
                        sql = @"SELECT 
                                p.Id,
                                p.nombre,
                                p.precio,
                                p.cod_barras,
                                s.cantidad AS stock
                            FROM Productos p
                            INNER JOIN Stock s ON s.IdProducto = p.Id
                            WHERE p.activo = 1
                            ORDER BY nombre COLLATE NOCASE ASC;";
                    }
                    else if (busqueda.All(char.IsLetter))
                    {
                        sql = @"SELECT
                                p.Id,
                                p.nombre,
                                p.precio,
                                p.cod_barras,
                                s.cantidad AS stock
                            FROM Productos p
                            INNER JOIN Stock s ON s.IdProducto = p.Id
                            WHERE p.nombre LIKE '%' || @busqueda || '%'
                            ORDER BY nombre COLLATE NOCASE ASC;";
                    }
                    else
                    {
                        sql = @"SELECT 
                                p.Id,
                                p.nombre,
                                p.precio,
                                p.cod_barras,
                                s.cantidad AS stock
                            FROM Productos p
                            INNER JOIN Stock s ON s.IdProducto = p.Id
                            WHERE
                                p.cod_barras = @busqueda
                                OR (
                                    LENGTH(@busqueda) > 3
                                    AND p.cod_barras LIKE SUBSTR(@busqueda, 1, LENGTH(@busqueda) - 3) || '%'
                                    AND NOT EXISTS (
                                        SELECT 1
                                        FROM Productos
                                        WHERE cod_barras = @busqueda
                                    )
                                )
                            ORDER BY
                                CASE
                                    WHEN p.cod_barras = @busqueda THEN 0
                                    ELSE 1
                                END
                            LIMIT 1;";
                    }
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", busqueda);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productos.Add(new ProductoStock
                                {
                                    Id = Convert.ToInt32(reader.GetValue(0)),
                                    Nombre = reader.GetString(1),
                                    Precio = Convert.ToDecimal(reader.GetValue(2), CultureInfo.InvariantCulture),
                                    CodigoBarras = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Stock = Convert.ToInt32(reader.GetValue(4))
                                });
                            }
                        }
                    }
                }

                return productos;
            }
        }
        // ================= VENTAS =================
        public List<Venta> ObtenerVentas()
        {
            var ventas = new List<Venta>();

            using (var conn = CrearConexion())
            {
                string sql = "SELECT Id, Fecha, Total FROM Venta";

                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ventas.Add(new Venta
                        {
                            IdVenta = Convert.ToInt32(reader.GetValue(0)),
                            Fecha = DateTime.ParseExact(
                                reader.GetString(1),
                                "yyyy-MM-dd HH:mm:ss",
                                CultureInfo.InvariantCulture),

                            Total = Convert.ToDecimal(reader.GetValue(2), CultureInfo.InvariantCulture)
                        });
                    }
                }
            }

            return ventas;
        }
        public List<Venta> ObtenerVentas(DateTime desde, DateTime hasta)
        {
            var ventas = new List<Venta>();

            using (var conn = CrearConexion())
            {
                string sql = "SELECT Id, Fecha, Total FROM Venta WHERE Fecha >= @desde and Fecha < @hasta";


                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@desde", desde.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy-MM-dd HH:mm:ss"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ventas.Add(new Venta
                            {
                                IdVenta = Convert.ToInt32(reader.GetValue(0)),
                                Fecha = DateTime.ParseExact(
                                    reader.GetString(1),
                                    "yyyy-MM-dd HH:mm:ss",
                                    CultureInfo.InvariantCulture),

                                Total = Convert.ToDecimal(reader.GetValue(2), CultureInfo.InvariantCulture)
                            });
                        }
                    }
                }
            }
            return ventas;
            }

        public List<VentaItem> ObtenerItems(int ventaId)
        {
            var items = new List<VentaItem>();

            using (var conn = CrearConexion())
            {
                string sql = @"
            SELECT Nombre, Cantidad, PrecioUnitario
            FROM VentaItem
            WHERE IdVenta = @ventaId";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ventaId", ventaId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(new VentaItem
                            {
                                NombreProducto = reader.GetString(0),
                                Cantidad = Convert.ToInt32(reader.GetValue(1)),
                                PrecioUnitario = Convert.ToDecimal(reader.GetValue(2), CultureInfo.InvariantCulture)
                            });
                        }
                    }
                }
            }

            return items;
        }

        // ================= GUARDAR VENTA =================

        public void GuardarVenta(Venta venta, List<VentaItem> items)
        {
            using (var conn = CrearConexion())
            using (var tx = conn.BeginTransaction())
            {
                long ventaId;

                using (var cmdVenta = conn.CreateCommand())
                {
                    cmdVenta.Transaction = tx;

                    cmdVenta.CommandText = @"
                INSERT INTO Venta (Fecha, Total)
                VALUES (@fecha, @total);
                SELECT last_insert_rowid();
            ";

                    cmdVenta.Parameters.AddWithValue(
                        "@fecha",
                        venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
                    cmdVenta.Parameters.AddWithValue("@total", venta.Total);

                    ventaId = Convert.ToInt64(cmdVenta.ExecuteScalar());
                }

                foreach (var item in items)
                {
                    using (var cmdItem = conn.CreateCommand())
                    {
                        cmdItem.Transaction = tx;

                        cmdItem.CommandText = @"
                    INSERT INTO VentaItem
                    (IdVenta, IdProducto, Nombre, PrecioUnitario, Cantidad)
                    VALUES
                    (@ventaId, @idProducto, @productoNombre, @precio, @cantidad);
                ";

                        cmdItem.Parameters.AddWithValue("@ventaId", ventaId);
                        cmdItem.Parameters.AddWithValue("@idProducto", item.IdProducto);
                        cmdItem.Parameters.AddWithValue("@productoNombre", item.NombreProducto);
                        cmdItem.Parameters.AddWithValue("@precio", item.PrecioUnitario);
                        cmdItem.Parameters.AddWithValue("@cantidad", item.Cantidad);

                        cmdItem.ExecuteNonQuery();
                    }

                    // Descontar stock
                    using (var cmdStock = conn.CreateCommand())
                    {
                        cmdStock.Transaction = tx;

                        cmdStock.CommandText = @"
                    UPDATE Stock
                    SET Cantidad = Cantidad - @cantidad
                    WHERE IdProducto = @productoId;
                ";

                        cmdStock.Parameters.AddWithValue("@productoId", item.IdProducto);
                        cmdStock.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        cmdStock.ExecuteNonQuery();
                    }
                }

                // 3️⃣ Confirmar todo
                tx.Commit();
            }
        }
        // ================= GUARDAR PRODUCTO =================

        public long GuardarProducto(Producto producto)
            {
                using (var conn = CrearConexion())
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        long productoId;

                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.Transaction = tx;

                            cmd.CommandText = @"
                                INSERT INTO Productos (nombre, precio, cod_barras, activo)
                                VALUES (@nombre, @precio, @cod_barras, 1);

                                SELECT last_insert_rowid();
                            ";

                            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                            cmd.Parameters.AddWithValue(
                                "@precio",
                                producto.Precio.ToString(CultureInfo.InvariantCulture));
                            cmd.Parameters.AddWithValue("@cod_barras", producto.CodigoBarras);

                            productoId = Convert.ToInt64(cmd.ExecuteScalar());
                        }

                        using (var cmdStock = conn.CreateCommand())
                        {
                            cmdStock.Transaction = tx;

                            cmdStock.CommandText = @"
                                INSERT INTO Stock (IdProducto, Cantidad)
                                VALUES (@productoId, @cantidadInicial);
                            ";

                            cmdStock.Parameters.AddWithValue("@productoId", productoId);
                            cmdStock.Parameters.AddWithValue("@cantidadInicial", 1);

                            cmdStock.ExecuteNonQuery();
                        }

                        tx.Commit();
                        return productoId;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }

        public void GuardarStock(ProductoStock producto)
        {
            using (var conn = CrearConexion())
            {
                string sql = "UPDATE Stock SET Cantidad = @cantidad WHERE IdProducto = @id";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("cantidad", producto.Stock);
                    cmd.Parameters.AddWithValue("id", producto.Id);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        MessageBox.Show("Producto editado correctamente.");
                    else MessageBox.Show("No se encontró el producto con ese Id.");
                }
            }
        }
    }
}
