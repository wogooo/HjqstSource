﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Logic_Character_Controller_EnemyControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Logic.Character.Controller.EnemyController), typeof(SingletonMono<Logic.Character.Controller.EnemyController>));
		L.RegFunction("GetEnemyHeroInfo", GetEnemyHeroInfo);
		L.RegFunction("GetEnemyPlayerInfo", GetEnemyPlayerInfo);
		L.RegFunction("GetComboEnemy", GetComboEnemy);
		L.RegFunction("SortSkillInfos", SortSkillInfos);
		L.RegFunction("CreateEnemys", CreateEnemys);
		L.RegFunction("CloneEnemy", CloneEnemy);
		L.RegFunction("CreateEnemy", CreateEnemy);
		L.RegFunction("CreateEnemyPlayer", CreateEnemyPlayer);
		L.RegFunction("Reborn", Reborn);
		L.RegFunction("AddHaloBuff", AddHaloBuff);
		L.RegFunction("RemovePlayerHaloBuff", RemovePlayerHaloBuff);
		L.RegFunction("AddFormationBuff", AddFormationBuff);
		L.RegFunction("Remove", Remove);
		L.RegFunction("RemoveAttackSkill", RemoveAttackSkill);
		L.RegFunction("ShowHPBarViews", ShowHPBarViews);
		L.RegFunction("ClearEnemy", ClearEnemy);
		L.RegFunction("ClearComboEnemies", ClearComboEnemies);
		L.RegFunction("Run_Scene", Run_Scene);
		L.RegFunction("ShowHPBar", ShowHPBar);
		L.RegFunction("PlayBossEffect", PlayBossEffect);
		L.RegFunction("isBoss", isBoss);
		L.RegFunction("get_Item", get_Item);
		L.RegFunction("GetDeadHeroById", GetDeadHeroById);
		L.RegFunction("SwitchEnemies", SwitchEnemies);
		L.RegFunction("ResetComboSkill", ResetComboSkill);
		L.RegFunction("HasFloatEnemies", HasFloatEnemies);
		L.RegFunction("HasTumbleEnemies", HasTumbleEnemies);
		L.RegFunction("CanFlaot", CanFlaot);
		L.RegFunction("CanSkill1Float", CanSkill1Float);
		L.RegFunction("CanSkill2Float", CanSkill2Float);
		L.RegFunction("CanTumble", CanTumble);
		L.RegFunction("CanSkill1Tumble", CanSkill1Tumble);
		L.RegFunction("CanSkill2Tumble", CanSkill2Tumble);
		L.RegFunction("HasCanOrderFloatEnemies", HasCanOrderFloatEnemies);
		L.RegFunction("HasCanOrderTumbleEnemies", HasCanOrderTumbleEnemies);
		L.RegFunction("CanOrderFlaot", CanOrderFlaot);
		L.RegFunction("CanOrderSkill1Float", CanOrderSkill1Float);
		L.RegFunction("CanOrderSkill2Float", CanOrderSkill2Float);
		L.RegFunction("CanOrderTumble", CanOrderTumble);
		L.RegFunction("CanOrderSkill1Tumble", CanOrderSkill1Tumble);
		L.RegFunction("CanOrderSkill2Tumble", CanOrderSkill2Tumble);
		L.RegVar("this", _this, null);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("enemyDic", get_enemyDic, null);
		L.RegVar("enemies", get_enemies, null);
		L.RegVar("deadEnemyDic", get_deadEnemyDic, null);
		L.RegVar("skillInfos", get_skillInfos, null);
		L.RegVar("tickCD", get_tickCD, set_tickCD);
		L.RegVar("lastTickTime", get_lastTickTime, set_lastTickTime);
		L.RegVar("enemyFloatable", get_enemyFloatable, set_enemyFloatable);
		L.RegVar("comboEnemyDic", get_comboEnemyDic, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			Logic.Character.EnemyEntity o = obj[arg0];
			ToLua.Push(L, o);
			return 1;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, null);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnemyHeroInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			Logic.Hero.Model.HeroInfo o = obj.GetEnemyHeroInfo(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnemyPlayerInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Player.Model.PlayerInfo o = obj.GetEnemyPlayerInfo();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComboEnemy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			Logic.Character.EnemyEntity o = obj.GetComboEnemy(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortSkillInfos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			obj.SortSkillInfos();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateEnemys(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			obj.CreateEnemys();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloneEnemy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.CloneEnemy(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateEnemy(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, typeof(Logic.Character.Controller.EnemyController), typeof(System.Collections.Generic.KeyValuePair<Logic.Enums.FormationPosition,Logic.Hero.Model.HeroInfo>), typeof(System.Action<Logic.Character.EnemyEntity>)))
			{
				Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.ToObject(L, 1);
				System.Collections.Generic.KeyValuePair<Logic.Enums.FormationPosition,Logic.Hero.Model.HeroInfo> arg0 = (System.Collections.Generic.KeyValuePair<Logic.Enums.FormationPosition,Logic.Hero.Model.HeroInfo>)ToLua.ToObject(L, 2);
				System.Action<Logic.Character.EnemyEntity> arg1 = null;
				LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

				if (funcType3 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (System.Action<Logic.Character.EnemyEntity>)ToLua.ToObject(L, 3);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 3);
					arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<Logic.Character.EnemyEntity>), func) as System.Action<Logic.Character.EnemyEntity>;
				}

				obj.CreateEnemy(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(Logic.Character.Controller.EnemyController), typeof(Logic.Fight.Model.FightHeroInfo), typeof(System.Action<bool>)))
			{
				Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.ToObject(L, 1);
				Logic.Fight.Model.FightHeroInfo arg0 = (Logic.Fight.Model.FightHeroInfo)ToLua.ToObject(L, 2);
				System.Action<bool> arg1 = null;
				LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

				if (funcType3 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (System.Action<bool>)ToLua.ToObject(L, 3);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 3);
					arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<bool>), func) as System.Action<bool>;
				}

				obj.CreateEnemy(arg0, arg1);
				return 0;
			}
			else if (count == 6 && TypeChecker.CheckTypes(L, typeof(Logic.Character.Controller.EnemyController), typeof(System.Collections.Generic.KeyValuePair<Logic.Enums.FormationPosition,Logic.Hero.Model.HeroInfo>), typeof(float), typeof(Logic.Team.Model.TeamData), typeof(System.Action<bool>), typeof(float)))
			{
				Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.ToObject(L, 1);
				System.Collections.Generic.KeyValuePair<Logic.Enums.FormationPosition,Logic.Hero.Model.HeroInfo> arg0 = (System.Collections.Generic.KeyValuePair<Logic.Enums.FormationPosition,Logic.Hero.Model.HeroInfo>)ToLua.ToObject(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				Logic.Team.Model.TeamData arg2 = (Logic.Team.Model.TeamData)ToLua.ToObject(L, 4);
				System.Action<bool> arg3 = null;
				LuaTypes funcType5 = LuaDLL.lua_type(L, 5);

				if (funcType5 != LuaTypes.LUA_TFUNCTION)
				{
					 arg3 = (System.Action<bool>)ToLua.ToObject(L, 5);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 5);
					arg3 = DelegateFactory.CreateDelegate(typeof(System.Action<bool>), func) as System.Action<bool>;
				}

				float arg4 = (float)LuaDLL.lua_tonumber(L, 6);
				obj.CreateEnemy(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Logic.Character.Controller.EnemyController.CreateEnemy");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateEnemyPlayer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Fight.Model.FightPlayerInfo arg0 = (Logic.Fight.Model.FightPlayerInfo)ToLua.CheckObject(L, 2, typeof(Logic.Fight.Model.FightPlayerInfo));
			System.Action<bool> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (System.Action<bool>)ToLua.CheckObject(L, 3, typeof(System.Action<bool>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<bool>), func) as System.Action<bool>;
			}

			obj.CreateEnemyPlayer(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reborn(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.CharacterEntity arg0 = (Logic.Character.CharacterEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.CharacterEntity));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			obj.Reborn(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddHaloBuff(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			obj.AddHaloBuff();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemovePlayerHaloBuff(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.HeroEntity arg0 = (Logic.Character.HeroEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.HeroEntity));
			obj.RemovePlayerHaloBuff(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddFormationBuff(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			obj.AddFormationBuff();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.Remove(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAttackSkill(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Skill.Model.SkillInfo arg0 = (Logic.Skill.Model.SkillInfo)ToLua.CheckObject(L, 2, typeof(Logic.Skill.Model.SkillInfo));
			obj.RemoveAttackSkill(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowHPBarViews(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.ShowHPBarViews(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearEnemy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			obj.ClearEnemy();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearComboEnemies(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.ClearComboEnemies(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Run_Scene(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			obj.Run_Scene();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowHPBar(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.ShowHPBar(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayBossEffect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			obj.PlayBossEffect();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isBoss(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.isBoss(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			Logic.Character.EnemyEntity o = obj[arg0];
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDeadHeroById(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			Logic.Character.EnemyEntity o = obj.GetDeadHeroById(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SwitchEnemies(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			Logic.Character.EnemyEntity arg1 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 3, typeof(Logic.Character.EnemyEntity));
			obj.SwitchEnemies(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetComboSkill(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 3);
			obj.ResetComboSkill(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasFloatEnemies(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			bool o = obj.HasFloatEnemies();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasTumbleEnemies(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			bool o = obj.HasTumbleEnemies();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanFlaot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanFlaot(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanSkill1Float(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanSkill1Float(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanSkill2Float(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanSkill2Float(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanTumble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanTumble(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanSkill1Tumble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanSkill1Tumble(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanSkill2Tumble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanSkill2Tumble(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasCanOrderFloatEnemies(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			bool o = obj.HasCanOrderFloatEnemies();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasCanOrderTumbleEnemies(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			bool o = obj.HasCanOrderTumbleEnemies();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanOrderFlaot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanOrderFlaot(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanOrderSkill1Float(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanOrderSkill1Float(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanOrderSkill2Float(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanOrderSkill2Float(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanOrderTumble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanOrderTumble(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanOrderSkill1Tumble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanOrderSkill1Tumble(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanOrderSkill2Tumble(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)ToLua.CheckObject(L, 1, typeof(Logic.Character.Controller.EnemyController));
			Logic.Character.EnemyEntity arg0 = (Logic.Character.EnemyEntity)ToLua.CheckUnityObject(L, 2, typeof(Logic.Character.EnemyEntity));
			bool o = obj.CanOrderSkill2Tumble(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
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
	static int get_enemyDic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			System.Collections.Generic.Dictionary<uint,Logic.Character.EnemyEntity> ret = obj.enemyDic;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index enemyDic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enemies(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			System.Collections.Generic.List<Logic.Character.EnemyEntity> ret = obj.enemies;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index enemies on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deadEnemyDic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			System.Collections.Generic.Dictionary<uint,Logic.Character.EnemyEntity> ret = obj.deadEnemyDic;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index deadEnemyDic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skillInfos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			System.Collections.Generic.List<Logic.Skill.Model.SkillInfo> ret = obj.skillInfos;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index skillInfos on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tickCD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			bool ret = obj.tickCD;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index tickCD on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lastTickTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			float ret = obj.lastTickTime;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index lastTickTime on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enemyFloatable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			bool ret = obj.enemyFloatable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index enemyFloatable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_comboEnemyDic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			System.Collections.Generic.Dictionary<uint,Logic.Character.EnemyEntity> ret = obj.comboEnemyDic;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index comboEnemyDic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tickCD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.tickCD = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index tickCD on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lastTickTime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.lastTickTime = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index lastTickTime on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enemyFloatable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Character.Controller.EnemyController obj = (Logic.Character.Controller.EnemyController)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.enemyFloatable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index enemyFloatable on a nil value" : e.Message);
		}
	}
}
