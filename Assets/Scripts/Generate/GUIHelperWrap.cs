﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GUIHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("GUIHelper");
		L.RegFunction("GetUIRootObj", GetUIRootObj);
		L.RegFunction("GetUICameraObj", GetUICameraObj);
		L.RegFunction("GetUIRoot", GetUIRoot);
		L.RegFunction("GetUICamera", GetUICamera);
		L.RegFunction("GetMainCamera", GetMainCamera);
		L.RegFunction("GetMainGameObj", GetMainGameObj);
		L.RegFunction("GetModelOutlineCameraObj", GetModelOutlineCameraObj);
		L.RegVar("DefaultSceneCullMask", get_DefaultSceneCullMask, set_DefaultSceneCullMask);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUIRootObj(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.GameObject o = GUIHelper.GetUIRootObj();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUICameraObj(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.GameObject o = GUIHelper.GetUICameraObj();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUIRoot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Canvas o = GUIHelper.GetUIRoot();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUICamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Camera o = GUIHelper.GetUICamera();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMainCamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Camera o = GUIHelper.GetMainCamera();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMainGameObj(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.GameObject o = GUIHelper.GetMainGameObj();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetModelOutlineCameraObj(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.GameObject o = GUIHelper.GetModelOutlineCameraObj();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DefaultSceneCullMask(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, GUIHelper.DefaultSceneCullMask);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DefaultSceneCullMask(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			GUIHelper.DefaultSceneCullMask = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
