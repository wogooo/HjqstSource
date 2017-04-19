﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_RandomWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Random), typeof(System.Object));
		L.RegFunction("Range", Range);
		L.RegFunction("New", _CreateUnityEngine_Random);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("seed", get_seed, set_seed);
		L.RegVar("value", get_value, null);
		L.RegVar("insideUnitSphere", get_insideUnitSphere, null);
		L.RegVar("insideUnitCircle", get_insideUnitCircle, null);
		L.RegVar("onUnitSphere", get_onUnitSphere, null);
		L.RegVar("rotation", get_rotation, null);
		L.RegVar("rotationUniform", get_rotationUniform, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Random(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Random obj = new UnityEngine.Random();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Random.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Range(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(int), typeof(int)))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				int o = UnityEngine.Random.Range(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, typeof(float), typeof(float)))
			{
				float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				float o = UnityEngine.Random.Range(arg0, arg1);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Random.Range");
			}
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
	static int get_seed(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Random.seed);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Random.value);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_insideUnitSphere(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Random.insideUnitSphere);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_insideUnitCircle(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Random.insideUnitCircle);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUnitSphere(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Random.onUnitSphere);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotation(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Random.rotation);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotationUniform(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Random.rotationUniform);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_seed(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Random.seed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
