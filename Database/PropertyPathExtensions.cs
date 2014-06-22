namespace AdventureWorks.Database 
{
    using NHibernate.Mapping.ByCode;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class PropertyPathExtensions
    {
        public static Type Owner(this PropertyPath member)
        {
            return member.GetRootMember().DeclaringType;
        }

        public static Type CollectionElementType(this PropertyPath member)
        {
            return member.LocalMember.GetPropertyOrFieldType().DetermineCollectionElementOrDictionaryValueType();
        }

        public static MemberInfo OneToManyOtherSideProperty(this PropertyPath member)
        {
            return member.CollectionElementType().GetFirstPropertyOfType(member.Owner());
        }
    }
}