﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SingletonPersistent_Logic_AdTracking_Controller_AdTrackingControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SingletonPersistent<Logic.AdTracking.Controller.AdTrackingController>), typeof(System.Object), "SingletonPersistent_Logic_AdTracking_Controller_AdTrackingController");
		L.RegFunction("New", _CreateSingletonPersistent_Logic_AdTracking_Controller_AdTrackingController);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("instance", get_instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSingletonPersistent_Logic_AdTracking_Controller_AdTrackingController(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SingletonPersistent<Logic.AdTracking.Controller.AdTrackingController> obj = new SingletonPersistent<Logic.AdTracking.Controller.AdTrackingController>();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SingletonPersistent<Logic.AdTracking.Controller.AdTrackingController>.New");
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
	static int get_instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, SingletonPersistent<Logic.AdTracking.Controller.AdTrackingController>.instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

