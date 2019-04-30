using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core
{
    public class UpdateModelHelp
    {
        public static void Update(object _old, object _new)
        {
            try
            {
                System.Reflection.MemberInfo[] memberCollection = _old.GetType().GetMembers();

                foreach (System.Reflection.MemberInfo member in memberCollection)
                {
                    if (member.MemberType == System.Reflection.MemberTypes.Field)
                    {
                        System.Reflection.FieldInfo field = (System.Reflection.FieldInfo)member;
                        Object fieldValue = field.GetValue(_old);
                        if (fieldValue == null) continue;
                        if (fieldValue is ICloneable)
                        {
                            field.SetValue(_new, (fieldValue as ICloneable).Clone());
                        }
                        else
                        {
                            if ((fieldValue.GetType().IsValueType == true))
                            {
                                field.SetValue(_new, fieldValue);
                            }
                        }

                    }
                    else if (member.MemberType == System.Reflection.MemberTypes.Property)
                    {
                        System.Reflection.PropertyInfo myProperty = (System.Reflection.PropertyInfo)member;
                        MethodInfo info = myProperty.GetSetMethod(false);
                        if (info != null)
                        {
                            object propertyValue = myProperty.GetValue(_old, null);
                            if (propertyValue == null) continue;
                            if (propertyValue is ICloneable)
                            {
                                myProperty.SetValue(_new, (propertyValue as ICloneable).Clone(), null);
                            }
                            else
                            {
                                if ((propertyValue.GetType().IsValueType == true))
                                {
                                    myProperty.SetValue(_new, propertyValue);
                                }
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {

            }
          
        }
    }
}
