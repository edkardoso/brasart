using System;
using Brasart.Domain.Common.ValueObjects;

namespace Brasart.Domain.Common.Entities
{
    public abstract class AuditableBaseEntity : BaseEntity
    {

        #region Fields


        #endregion

        #region Properties
        public Guid CreatedBy { get; protected set; }
        public DateTime Created { get; protected set; }
        public Guid LastModifiedBy { get; protected set; }
        public DateTimeOffset CreatedAt { get; protected set; }
        public DateTimeOffset? UpdatedAt { get; protected set; }

        #endregion

        #region Constructors
        protected AuditableBaseEntity()
        {

            // TODO: Rever a criação das datas para auditoria
            CreatedBy = GuidVo.Value;
            Created = DateTimeVo.Now().Date;
            CreatedAt = DateTimeVo.UtcNow;
            LastModifiedBy = GuidVo.Value;
            UpdatedAt = DateTimeVo.UtcNow;
        }

        protected AuditableBaseEntity(Guid? id, bool active, bool dead) : base(id, active, dead)
        {
            CreatedBy = GuidVo.Value;
            Created = DateTimeVo.Now().Date;
            CreatedAt = DateTimeVo.UtcNow;
            LastModifiedBy = GuidVo.Value;
            UpdatedAt = DateTimeVo.UtcNow;
        }

        #endregion

        #region Methods

        #endregion
    }
}
