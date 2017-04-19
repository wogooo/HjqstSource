﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Logic_Action_Controller_ActionControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Logic.Action.Controller.ActionController), typeof(SingletonMono<Logic.Action.Controller.ActionController>));
		L.RegFunction("PlayerAnimAction", PlayerAnimAction);
		L.RegFunction("SetAnimBoolean", SetAnimBoolean);
		L.RegFunction("MoveTarget", MoveTarget);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayerAnimAction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, typeof(Logic.Action.Controller.ActionController), typeof(Logic.Character.CharacterEntity), typeof(int)))
			{
				Logic.Action.Controller.ActionController obj = (Logic.Action.Controller.ActionController)ToLua.ToObject(L, 1);
				Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.PlayerAnimAction(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, typeof(Logic.Action.Controller.ActionController), typeof(Logic.Character.CharacterEntity), typeof(int), typeof(float)))
			{
				Logic.Action.Controller.ActionController obj = (Logic.Action.Controller.ActionController)ToLua.ToObject(L, 1);
				Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.PlayerAnimAction(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Logic.Action.Controller.ActionController.PlayerAnimAction");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAnimBoolean(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Logic.Action.Controller.ActionController obj = (Logic.Action.Controller.ActionController)ToLua.CheckObject(L, 1, typeof(Logic.Action.Controller.ActionController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			string arg1 = ToLua.CheckString(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.SetAnimBoolean(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveTarget(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Logic.Action.Controller.ActionController obj = (Logic.Action.Controller.ActionController)ToLua.CheckObject(L, 1, typeof(Logic.Action.Controller.ActionController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			obj.MoveTarget(arg0, arg1, arg2);
			return 0;
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
}
