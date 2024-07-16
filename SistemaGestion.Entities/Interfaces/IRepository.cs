namespace SistemaGestion.Entities.Interfaces
{
    public interface IRepository<T>
    {
        List<T> ObtenerTodosLosRegistros();
        T ObtenerPorId(int id);
        void InsertarRegistro(T registro);
        void EliminarRegistro(T registro);
        void ActualizarRegistro(T registro);
    }
}
