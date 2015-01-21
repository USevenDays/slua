﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_InputField_ContentType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.InputField.ContentType o = (UnityEngine.UI.InputField.ContentType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.InputField.ContentType");
		addMember(l,0,"Standard");
		addMember(l,1,"Autocorrected");
		addMember(l,2,"IntegerNumber");
		addMember(l,3,"DecimalNumber");
		addMember(l,4,"Alphanumeric");
		addMember(l,5,"Name");
		addMember(l,6,"EmailAddress");
		addMember(l,7,"Password");
		addMember(l,8,"Pin");
		addMember(l,9,"Custom");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
