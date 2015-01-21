﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Sprites_DataUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Sprites.DataUtility o;
		if(matchType(l,1)){
			o=new UnityEngine.Sprites.DataUtility();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInnerUV(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 ret=UnityEngine.Sprites.DataUtility.GetInnerUV(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOuterUV(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 ret=UnityEngine.Sprites.DataUtility.GetOuterUV(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPadding(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 ret=UnityEngine.Sprites.DataUtility.GetPadding(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMinSize(IntPtr l) {
		try{
			UnityEngine.Sprite a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 ret=UnityEngine.Sprites.DataUtility.GetMinSize(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Sprites.DataUtility");
		addMember(l,GetInnerUV);
		addMember(l,GetOuterUV);
		addMember(l,GetPadding);
		addMember(l,GetMinSize);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Sprites.DataUtility));
	}
}
