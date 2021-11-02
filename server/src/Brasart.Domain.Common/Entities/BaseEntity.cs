using System;
using Brasart.Domain.Common.ValueObjects;
using Electra.Solvace.Core.Commom.Exceptions;

namespace Brasart.Domain.Common.Entities
{
    public abstract class BaseEntity
    {
        #region Fields


        #endregion

        #region Properties
        public Guid? Id { get; private set; }
        public bool Dead { get; private set; }
        public bool Active { get; private set; }

        #endregion

        #region Constructors
        protected BaseEntity()
        {
        }

        protected BaseEntity(Guid? id, bool active, bool dead)
        {
            Id = id ?? GuidVo.Value;
            Active = active;

            if (Dead && !dead)
                if (id != null)
                    throw new InvalidOperationRecordDelete(id.Value);

            Dead = dead;

            IsValid();
        }

        #endregion

        #region Methods
        public void Activate() => Active = true;

        public void Deactivate() => Active = false;

        public void MarkAsExcluded() => Dead = true;

        public virtual void IsValid()
        {

        }

        #endregion
    }
}
