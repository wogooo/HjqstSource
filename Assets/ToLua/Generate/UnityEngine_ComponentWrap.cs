﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ComponentWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Component), typeof(UnityEngine.Object));
		L.RegFunction("GetComponent", GetComponent);
		L.RegFunction("GetComponentInChildren", GetComponentInChildren);
		L.RegFunction("GetComponentsInChildren", GetComponentsInChildren);
		L.RegFunction("GetComponentInParent", GetComponentInParent);
		L.RegFunction("GetComponentsInParent", GetComponentsInParent);
		L.RegFunction("GetComponents", GetComponents);
		L.RegFunction("CompareTag", CompareTag);
		L.RegFunction("SendMessageUpwards", SendMessageUpwards);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("BroadcastMessage", BroadcastMessage);
		L.RegFunction("New", _CreateUnityEngine_Component);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("transform", get_transform, null);
		L.RegVar("gameObject", get_gameObject, null);
		L.RegVar("tag", get_tag, set_tag);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Component(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Component obj = new UnityEngine.Component();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Component.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.Component o = obj.GetComponent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(System.Type)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component o = obj.GetComponent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponent");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject(L, 1, typeof(UnityEngine.Component));
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 2, typeof(System.Type));
			UnityEngine.Component o = obj.GetComponentInChildren(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInChildren(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(System.Type)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component[] o = obj.GetComponentsInChildren(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(System.Type), typeof(bool)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Component[] o = obj.GetComponentsInChildren(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponentsInChildren");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInParent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject(L, 1, typeof(UnityEngine.Component));
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 2, typeof(System.Type));
			UnityEngine.Component o = obj.GetComponentInParent(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInParent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(System.Type)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component[] o = obj.GetComponentsInParent(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(System.Type), typeof(bool)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Component[] o = obj.GetComponentsInParent(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponentsInParent");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponents(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(System.Type)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				UnityEngine.Component[] o = obj.GetComponents(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(System.Type), typeof(System.Collections.Generic.List<UnityEngine.Component>)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				System.Collections.Generic.List<UnityEngine.Component> arg1 = (System.Collections.Generic.List<UnityEngine.Component>)ToLua.ToObject(L, 3);
				obj.GetComponents(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.GetComponents");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareTag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Component obj = (UnityEngine.Component)ToLua.CheckObject(L, 1, typeof(UnityEngine.Component));
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.CompareTag(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessageUpwards(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.SendMessageUpwards(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessageUpwards(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(object)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessageUpwards(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(object), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 4);
				obj.SendMessageUpwards(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.SendMessageUpwards");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.SendMessage(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(object)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(object), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 4);
				obj.SendMessage(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.SendMessage");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BroadcastMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.BroadcastMessage(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.BroadcastMessage(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(object)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.BroadcastMessage(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, typeof(UnityEngine.Component), typeof(string), typeof(object), typeof(UnityEngine.SendMessageOptions)))
			{
				UnityEngine.Component obj = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 4);
				obj.BroadcastMessage(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Component.BroadcastMessage");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			UnityEngine.Transform ret = obj.transform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index transform on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			UnityEngine.GameObject ret = obj.gameObject;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index gameObject on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			string ret = obj.tag;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index tag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Component obj = (UnityEngine.Component)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.tag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index tag on a nil value" : e.Message);
		}
	}
}

