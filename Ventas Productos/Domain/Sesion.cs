using System;
using Ventas_Productos.Domain;

public static class Sesion
{
    private static Usuario _usuario = null;

    public static Usuario Usuario => _usuario;
    public static bool EstaAutenticado => _usuario != null;

    public static event Action UsuarioCambio;

    public static void Autenticar(Usuario usuario)
    {
        _usuario = usuario;
        UsuarioCambio?.Invoke();
    }

    public static void CerrarSesion()
    {
        _usuario = null;
        UsuarioCambio?.Invoke();
    }
}