using System;

namespace Brasart.Domain.Common.Extensions
{
    public static class GuidExtensions
    {
        public static int CreateHashCode(this Guid? guid)
        {
            var hascode = 41;
            if (guid == null) return hascode;

            return hascode * 59 * guid.GetHashCode();
        }
    }
}
