namespace ProductManagment.Interfaces
{
    public interface IMapper<TEntity, TModel>
    {
        TModel MapFromEntityToModel(TEntity source);

        TEntity MapFromModelToEntity(TModel source);

        void MapFromModelToEntity(TModel source, TEntity target);
    }
}
