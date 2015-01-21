﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Text : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FontTextureChanged(IntPtr l) {
		try{
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
			self.FontTextureChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGenerationSettings(IntPtr l) {
		try{
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.TextGenerationSettings ret=self.GetGenerationSettings(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTextAnchorPivot(IntPtr l) {
		try{
			UnityEngine.TextAnchor a1;
			checkEnum(l,1,out a1);
			UnityEngine.Vector2 ret=UnityEngine.UI.Text.GetTextAnchorPivot(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
			self.CalculateLayoutInputHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		try{
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
			self.CalculateLayoutInputVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnRebuildRequested(IntPtr l) {
		try{
			UnityEngine.UI.Text self=(UnityEngine.UI.Text)checkSelf(l);
			self.OnRebuildRequested();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTextGenerator(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.cachedTextGenerator);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTextGeneratorForLayout(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.cachedTextGeneratorForLayout);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultMaterial(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.defaultMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportRichText(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.supportRichText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_supportRichText(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.supportRichText=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextForBestFit(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.resizeTextForBestFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextForBestFit(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.resizeTextForBestFit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMinSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.resizeTextMinSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMinSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.resizeTextMinSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resizeTextMaxSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.resizeTextMaxSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resizeTextMaxSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.resizeTextMaxSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.horizontalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.HorizontalWrapMode v;
		checkEnum(l,2,out v);
		o.horizontalOverflow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.verticalOverflow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalOverflow(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.VerticalWrapMode v;
		checkEnum(l,2,out v);
		o.verticalOverflow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineSpacing(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.lineSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineSpacing(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.lineSpacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelsPerUnit(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.pixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.Text o = (UnityEngine.UI.Text)checkSelf(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Text");
		addMember(l,FontTextureChanged);
		addMember(l,GetGenerationSettings);
		addMember(l,GetTextAnchorPivot);
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,OnRebuildRequested);
		addMember(l,"cachedTextGenerator",get_cachedTextGenerator,null);
		addMember(l,"cachedTextGeneratorForLayout",get_cachedTextGeneratorForLayout,null);
		addMember(l,"defaultMaterial",get_defaultMaterial,null);
		addMember(l,"mainTexture",get_mainTexture,null);
		addMember(l,"font",get_font,set_font);
		addMember(l,"text",get_text,set_text);
		addMember(l,"supportRichText",get_supportRichText,set_supportRichText);
		addMember(l,"resizeTextForBestFit",get_resizeTextForBestFit,set_resizeTextForBestFit);
		addMember(l,"resizeTextMinSize",get_resizeTextMinSize,set_resizeTextMinSize);
		addMember(l,"resizeTextMaxSize",get_resizeTextMaxSize,set_resizeTextMaxSize);
		addMember(l,"alignment",get_alignment,set_alignment);
		addMember(l,"fontSize",get_fontSize,set_fontSize);
		addMember(l,"horizontalOverflow",get_horizontalOverflow,set_horizontalOverflow);
		addMember(l,"verticalOverflow",get_verticalOverflow,set_verticalOverflow);
		addMember(l,"lineSpacing",get_lineSpacing,set_lineSpacing);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle);
		addMember(l,"pixelsPerUnit",get_pixelsPerUnit,null);
		addMember(l,"minWidth",get_minWidth,null);
		addMember(l,"preferredWidth",get_preferredWidth,null);
		addMember(l,"flexibleWidth",get_flexibleWidth,null);
		addMember(l,"minHeight",get_minHeight,null);
		addMember(l,"preferredHeight",get_preferredHeight,null);
		addMember(l,"flexibleHeight",get_flexibleHeight,null);
		addMember(l,"layoutPriority",get_layoutPriority,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Text),typeof(UnityEngine.UI.MaskableGraphic));
	}
}
