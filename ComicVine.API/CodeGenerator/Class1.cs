﻿//namespace ComicVineScraper.API.CodeGenerator
//{
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Reflection;

//    class Class1
//    {
//        string CleanPropertyType(string root, System.Type type)
//        {
//            return type.ToString()
//                .Replace(root + ".", "")
//                .Replace("Schema.", "")
//                .Replace("System.", "")
//                .Replace("String", "string")
//                .Replace("Int32", "int")
//                .Replace("Int64", "long")
//                .Replace("Decimal", "decimal")
//                .Replace("Boolean", "bool")
//                .Replace("Nullable`1[int]", "int?")
//                .Replace("Nullable`1[long]", "long?")
//                .Replace("Nullable`1[bool]", "bool?")
//                .Replace("Nullable`1[decimal]", "decimal?")
//                .Replace("Nullable`1[DateTime]", "DateTime?")
//                .Replace("Nullable`1[Guid]", "Guid?")
//                .Replace("Collections.Generic.ICollection`1", "List").Replace("[", "<").Replace("]", ">")
//                .Replace("Collections.Generic.ICollection`1", "List").Replace("[", "<").Replace("]", ">")
//                .Replace("Byte", "byte")
//                .Replace("byte<>", "byte[]");
//        }
//        bool IsNameable(System.Type t, PropertyInfo p)
//        {
//            return t.BaseType != null
//                && (p.PropertyType.BaseType == typeof(NameableEntityBase)
//                    /*|| p.PropertyType.BaseType == typeof(ContactableEntityBase)
//                    || p.PropertyType.BaseType == typeof(SalesEntityBase)
//                    || p.PropertyType.BaseType == typeof(SalesItemEntityBase)*/);
//        }
//        bool IsContactable(System.Type t)
//        {
//            return false; //t.BaseType != null && (t.BaseType == typeof(ContactableSharedBase));
//        }
//        bool IsAttributable(System.Type t)
//        {
//            return false; //t.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IAttributableSharedBase)),
//        }
//        bool IsFilterable(PropertyInfo p)
//        {
//            return p.GetCustomAttributes()
//                .Any(ca => (ca is SearchableBooleanAttribute)
//                        || (ca is SearchableStringAttribute)
//                        || (ca is SearchableIntAttribute) || (ca is SearchableNullableIntAttribute)
//                        || (ca is SearchableDecimalAttribute) || (ca is SearchableNullableDecimalAttribute));
//        }
//        bool GetFilterName(PropertyInfo p)
//        {
//            return p.GetCustomAttributes().Any(ca => ca is SearchableBooleanAttribute) ? ((SearchableBooleanAttribute)p.GetCustomAttributes().First(ca => ca is SearchableBooleanAttribute)).SearchName
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableStringAttribute) ? ((SearchableStringAttribute)p.GetCustomAttributes().First(ca => ca is SearchableStringAttribute)).SearchName
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableIntAttribute) ? ((SearchableIntAttribute)p.GetCustomAttributes().First(ca => ca is SearchableIntAttribute)).SearchName
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableNullableIntAttribute) ? ((SearchableNullableIntAttribute)p.GetCustomAttributes().First(ca => ca is SearchableNullableIntAttribute)).SearchName
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableDecimalAttribute) ? ((SearchableDecimalAttribute)p.GetCustomAttributes().First(ca => ca is SearchableDecimalAttribute)).SearchName
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableNullableDecimalAttribute) ? ((SearchableNullableDecimalAttribute)p.GetCustomAttributes().First(ca => ca is SearchableNullableDecimalAttribute)).SearchName
//                 : p.Name;
//        }
//        bool GetFilterDescription(PropertyInfo p)
//        {
//            return p.GetCustomAttributes().Any(ca => ca is SearchableBooleanAttribute) ? ((SearchableBooleanAttribute)p.GetCustomAttributes().First(ca => ca is SearchableBooleanAttribute)).SearchDescription
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableStringAttribute) ? ((SearchableStringAttribute)p.GetCustomAttributes().First(ca => ca is SearchableStringAttribute)).SearchDescription
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableIntAttribute) ? ((SearchableIntAttribute)p.GetCustomAttributes().First(ca => ca is SearchableIntAttribute)).SearchDescription
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableNullableIntAttribute) ? ((SearchableNullableIntAttribute)p.GetCustomAttributes().First(ca => ca is SearchableNullableIntAttribute)).SearchDescription
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableDecimalAttribute) ? ((SearchableDecimalAttribute)p.GetCustomAttributes().First(ca => ca is SearchableDecimalAttribute)).SearchDescription
//                 : p.GetCustomAttributes().Any(ca => ca is SearchableNullableDecimalAttribute) ? ((SearchableNullableDecimalAttribute)p.GetCustomAttributes().First(ca => ca is SearchableNullableDecimalAttribute)).SearchDescription
//                 : string.Format("The {0} to search by.", p.Name);
//        }
//        Dictionary<string, List<classInfo>> DataModelParser(string root)
//        {
//            // Parse the DataModel
//            var nameSpaces = new Dictionary<string, List<classInfo>>();
//            foreach (var classType in from t in Assembly.GetAssembly(typeof(ModelEntities)).GetTypes()
//                                      where t.IsClass && t.Namespace == root + ".DataModel.Schema"
//                                      select t)
//            {
//                var table = classType.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.TableAttribute))
//                                as System.ComponentModel.DataAnnotations.Schema.TableAttribute;
//                if (table == null) { continue; }
//                var name = table.Name;
//                if (name.Contains('.')) { name = name.Split('.')[0]; }
//                if (name == "System") { name = "Structure"; } // Don't override System by accident
//                if (!nameSpaces.ContainsKey(name)) { nameSpaces[name] = new List<classInfo>(); }
//                // Now that we know for sure the Namespace is recorded
//                // let's add this class to the Entities list
//                var classInfo = new classInfo
//                {
//                    name = classType.ToString().Replace(root + ".DataModel.", ""),
//                    baseClassName = classType.BaseType == null ? null : classType.BaseType.ToString().Replace(root + ".DataModel.", "").Replace("EntityBase", ""),
//                    isAttributable = false/*ImplementsInterface(classType, typeof(IAttributableSharedBase))*/,
//                    properties = classType
//                        .GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
//                        .Select(p => new propertyInfo
//                        {
//                            name = p.Name,
//                            type = CleanPropertyType(root, p.PropertyType),
//                            isNameable = IsNameable(p.PropertyType, p),
//                            isContactable = IsContactable(p.PropertyType),
//                            isAttributable = IsAttributable(p.PropertyType),
//                            isFilterable = IsFilterable(p),
//                            filterName = GetFilterName(p),
//                            filterDescription = GetFilterDescription(p)
//                        }).ToList()
//                };
//                nameSpaces[name].Add(classInfo);
//            }
//        }
//    }
//}
