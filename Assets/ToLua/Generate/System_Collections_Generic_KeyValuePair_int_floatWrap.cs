﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Collections_Generic_KeyValuePair_int_floatWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Collections.Generic.KeyValuePair<int,float>), null, "KeyValuePair_int_float");
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateSystem_Collections_Generic_KeyValuePair_int_float);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Key", get_Key, null);
		L.RegVar("Value", get_Value, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSystem_Collections_Generic_KeyValuePair_int_float(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				System.Collections.Generic.KeyValuePair<int,float> obj = new System.Collections.Generic.KeyValuePair<int,float>(arg0, arg1);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 0)
			{
				System.Collections.Generic.KeyValuePair<int,float> obj = new System.Collections.Generic.KeyValuePair<int,float>();
				ToLua.PushValue(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: System.Collections.Generic.KeyValuePair<int,float>.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.Generic.KeyValuePair<int,float> obj = (System.Collections.Generic.KeyValuePair<int,float>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.KeyValuePair<int,float>));
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
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
	static int get_Key(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.Generic.KeyValuePair<int,float> obj = (System.Collections.Generic.KeyValuePair<int,float>)o;
			int ret = obj.Key;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Key on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Collections.Generic.KeyValuePair<int,float> obj = (System.Collections.Generic.KeyValuePair<int,float>)o;
			float ret = obj.Value;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Value on a nil value" : e.Message);
		}
	}
}

