using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Models
{
    public static class ContextExtensions
    {
        private static readonly List<Action<IMutableEntityType>> Conventions = new();

        public static void AddRemoveOneToManyCascadeConvention(this ModelBuilder builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            Conventions.Add(et => et.GetForeignKeys()
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                .ToList()
                .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict));
        }

        public static void ApplyConventions(this ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                foreach (Action<IMutableEntityType> action in Conventions)
                    action(entityType);
            }

            Conventions.Clear();
        }
    }
}
