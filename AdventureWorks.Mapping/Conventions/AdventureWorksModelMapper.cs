namespace AdventureWorks.Mapping.Conventions
{
    using NHibernate.Mapping.ByCode;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdventureWorksModelMapper : ConventionModelMapper
    {
        public AdventureWorksModelMapper()
        {
            this.BeforeMapClass += IdMapper;
        }

        public static void IdMapper(IModelInspector modelInspector, Type type, IClassAttributesMapper mapper)
        {
            mapper.Id(x =>
            {
                x.Column(type.Name + "ID");
                x.Generator(Generators.Identity);
            });
        }
    }
}
