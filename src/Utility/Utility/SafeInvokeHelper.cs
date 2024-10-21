using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;

// Token: 0x0200000B RID: 11
public class SafeInvokeHelper
{
	// Token: 0x06000028 RID: 40 RVA: 0x000029C4 File Offset: 0x000019C4
	static SafeInvokeHelper()
	{
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Name = "temp";
		SafeInvokeHelper.myAsmBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
		SafeInvokeHelper.builder = SafeInvokeHelper.myAsmBuilder.DefineDynamicModule("TempModule");
		SafeInvokeHelper.methodLookup = new Hashtable();
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002A14 File Offset: 0x00001A14
	public static object Invoke(Control obj, string methodName, params object[] paramValues)
	{
		string key = obj.GetType().Name + "." + methodName;
		Type type;
		lock (SafeInvokeHelper.methodLookup)
		{
			if (SafeInvokeHelper.methodLookup.Contains(key))
			{
				type = (Type)SafeInvokeHelper.methodLookup[key];
			}
			else
			{
				Type[] array = new Type[obj.GetType().GetMethod(methodName).GetParameters().Length];
				int num = 0;
				foreach (ParameterInfo parameterInfo in obj.GetType().GetMethod(methodName).GetParameters())
				{
					array[num++] = parameterInfo.ParameterType;
				}
				TypeBuilder typeBuilder = SafeInvokeHelper.builder.DefineType("Del_" + obj.GetType().Name + "_" + methodName, TypeAttributes.Public | TypeAttributes.Sealed, typeof(MulticastDelegate), PackingSize.Unspecified);
				ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard, new Type[]
				{
					typeof(object),
					typeof(IntPtr)
				});
				constructorBuilder.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
				MethodBuilder methodBuilder = typeBuilder.DefineMethod("Invoke", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, obj.GetType().GetMethod(methodName).ReturnType, array);
				methodBuilder.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
				type = typeBuilder.CreateType();
				SafeInvokeHelper.methodLookup.Add(key, type);
			}
		}
		Delegate method = Delegate.CreateDelegate(type, obj, methodName);
		return obj.Invoke(method, paramValues);
	}

	// Token: 0x04000010 RID: 16
	private static readonly ModuleBuilder builder;

	// Token: 0x04000011 RID: 17
	private static readonly AssemblyBuilder myAsmBuilder;

	// Token: 0x04000012 RID: 18
	private static readonly Hashtable methodLookup;
}
