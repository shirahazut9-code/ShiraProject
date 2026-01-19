using Model;
using System.Data.OleDb;

namespace ViewModel
{
    internal class ChangeEntity
    {
        private Action<BaseEntity, OleDbCommand> createUpdatedSQL;
        private BaseEntity entity;

        public ChangeEntity(Action<BaseEntity, OleDbCommand> createUpdatedSQL, BaseEntity entity)
        {
            this.createUpdatedSQL = createUpdatedSQL;
            this.entity = entity;
        }
    }
}