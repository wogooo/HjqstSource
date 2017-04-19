﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Logic_Fight_Controller_MechanicsControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Logic.Fight.Controller.MechanicsController), typeof(SingletonMono<Logic.Fight.Controller.MechanicsController>));
		L.RegFunction("SetDamageValue", SetDamageValue);
		L.RegFunction("CalcDamage", CalcDamage);
		L.RegFunction("SetTreatValue", SetTreatValue);
		L.RegFunction("PlayBuffEffect", PlayBuffEffect);
		L.RegFunction("SetAngry", SetAngry);
		L.RegFunction("Transform", Transform);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDamageValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 8);
			Logic.Fight.Controller.MechanicsController obj = (Logic.Fight.Controller.MechanicsController)ToLua.CheckObject(L, 1, typeof(Logic.Fight.Controller.MechanicsController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			Logic.Character.CharacterEntity arg1 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 3, typeof(Logic.Character.CharacterEntity));
			Logic.Skill.Model.SkillInfo arg2 = (Logic.Skill.Model.SkillInfo)ToLua.CheckObject(L, 4, typeof(Logic.Skill.Model.SkillInfo));
			uint arg3 = (uint)LuaDLL.luaL_checknumber(L, 5);
			bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
			int arg6 = (int)LuaDLL.luaL_checknumber(L, 8);
			obj.SetDamageValue(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalcDamage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 10);
			Logic.Fight.Controller.MechanicsController obj = (Logic.Fight.Controller.MechanicsController)ToLua.CheckObject(L, 1, typeof(Logic.Fight.Controller.MechanicsController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			Logic.Character.CharacterEntity arg1 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 3, typeof(Logic.Character.CharacterEntity));
			Logic.Skill.Model.SkillInfo arg2 = (Logic.Skill.Model.SkillInfo)ToLua.CheckObject(L, 4, typeof(Logic.Skill.Model.SkillInfo));
			Logic.Skill.Model.MechanicsData arg3 = (Logic.Skill.Model.MechanicsData)ToLua.CheckObject(L, 5, typeof(Logic.Skill.Model.MechanicsData));
			int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
			float arg6 = (float)LuaDLL.luaL_checknumber(L, 8);
			float arg7 = (float)LuaDLL.luaL_checknumber(L, 9);
			float arg8 = (float)LuaDLL.luaL_checknumber(L, 10);
			obj.CalcDamage(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTreatValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Logic.Fight.Controller.MechanicsController obj = (Logic.Fight.Controller.MechanicsController)ToLua.CheckObject(L, 1, typeof(Logic.Fight.Controller.MechanicsController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.SetTreatValue(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayBuffEffect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Logic.Fight.Controller.MechanicsController obj = (Logic.Fight.Controller.MechanicsController)ToLua.CheckObject(L, 1, typeof(Logic.Fight.Controller.MechanicsController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			Logic.Skill.Model.MechanicsData arg1 = (Logic.Skill.Model.MechanicsData)ToLua.CheckObject(L, 3, typeof(Logic.Skill.Model.MechanicsData));
			obj.PlayBuffEffect(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAngry(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Fight.Controller.MechanicsController obj = (Logic.Fight.Controller.MechanicsController)ToLua.CheckObject(L, 1, typeof(Logic.Fight.Controller.MechanicsController));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.SetAngry(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Transform(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Logic.Fight.Controller.MechanicsController obj = (Logic.Fight.Controller.MechanicsController)ToLua.CheckObject(L, 1, typeof(Logic.Fight.Controller.MechanicsController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			obj.Transform(arg0, arg1, arg2);
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

