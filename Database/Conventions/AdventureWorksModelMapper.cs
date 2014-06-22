namespace AdventureWorks.Database.Conventions
{
    using AdventureWorks.Entities;
    using AdventureWorks.Entities.Production;
    using NHibernate.Mapping.ByCode;
    using AdventureWorks.Database;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using AdventureWorks.Entities.Person;

    public class AdventureWorksModelMapper : ConventionModelMapper
    {
        private const string ForeignKeyColumnPostfix = "ID";
        private Type _baseEntityType;

        public AdventureWorksModelMapper(Type baseEntityType)
        {
            this._baseEntityType = baseEntityType;

            this.BeforeMapJoinedSubclass += DefaultSubclassMapper;
            this.BeforeMapClass += DefaultClassMapper;
            this.BeforeMapProperty += DefaultPropertyMapper;
            this.BeforeMapManyToOne += DefaultMapManyToOne;
            this.BeforeMapList += DefaultMapCollection;
            this.BeforeMapSet += DefaultMapCollection;
            this.BeforeMapBag += DefaultMapCollection;
            this.BeforeMapList += DefaultMapCollection;
            this.BeforeMapIdBag += DefaultMapCollection;
            this.BeforeMapMap += DefaultMapCollection;
            this.BeforeMapOneToOne += DefaultMapOneToOne;

            this.IsEntity(this._isEntity);
            this.IsRootEntity(this._isRootEntity);
        }

        private bool _isEntity(Type type, bool declared) 
        {
            return this._baseEntityType.IsAssignableFrom(type) &&
                    type != this._baseEntityType;
        }

        private bool _isRootEntity(Type type, bool declared)
        {
            return this._baseEntityType == type.BaseType;
        }

        private void DefaultMapOneToOne(IModelInspector inspector, PropertyPath member, IOneToOneMapper mapper)
        {
            Console.WriteLine("asdfasdf");
        }

        private void DefaultMapManyToOne(IModelInspector inspector, PropertyPath member, IManyToOneMapper customizer)
        {
            customizer.Column(member.LocalMember.Name + ForeignKeyColumnPostfix);
        }

        private void DefaultMapCollection(IModelInspector inspector, PropertyPath member, ICollectionPropertiesMapper customizer)
        {
            customizer.Key(k => k.Column(DetermineKeyColumnName(inspector, member)));
        }

        private static string DetermineKeyColumnName(IModelInspector inspector, PropertyPath member)
        {
            var otherSideProperty = member.OneToManyOtherSideProperty();
            if (inspector.IsOneToMany(member.LocalMember) && otherSideProperty != null)
            {
                return otherSideProperty.Name + ForeignKeyColumnPostfix;
            }

            return member.Owner().Name + ForeignKeyColumnPostfix;
        }

        public static void DefaultSubclassMapper(IModelInspector modelInspector, Type type, IJoinedSubclassAttributesMapper mapper)
        {
            mapSchema(mapper.Schema, type);

            mapper.Key(key =>
            {
                key.Column(type.BaseType.Name + ForeignKeyColumnPostfix);
            }); 
        }

        private static void mapSchema(Action<string> schemaMapper, Type type)
        {
            string[] elements = type.Namespace.Split('.');

            if (elements.Last() != "Mapping")
            {
                schemaMapper(elements.Last());
            }
        }

        public static void DefaultClassMapper(IModelInspector modelInspector, Type type, IClassAttributesMapper mapper)
        {
            mapSchema(mapper.Schema, type);

            mapper.Id(id =>
            {
                id.Column(type.Name + ForeignKeyColumnPostfix);
                id.Generator(Generators.Identity);
            });
        }

        public static void DefaultPropertyMapper(IModelInspector modelInspector, PropertyPath path, IPropertyMapper mapper)
        {
            if (path.LocalMember.GetPropertyOrFieldType() == typeof(bool))
            {
                mapper.Column(path.ToColumnName() + "Flag");
            }
        }

    }
}
