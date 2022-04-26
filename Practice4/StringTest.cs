using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Practice4
{
	[TestFixture()]
	class StringTest
	{
		StringPrac StringCore = new StringPrac();
		[TestCase( "日本隊", Result = true )]
		[TestCase( "打安打", Result = false )]
		[TestCase( "Johan Mieses", Result = true )]
		[TestCase( "手保送首", Result = true )]
		[TestCase( "人速度", Result = false )]
		[TestCase( "八局下", Result = false )]
		[TestCase( "。", Result = true )]

		[Test()]
		public bool Findtest( string szFindStr )
		{
			string szTest = "8局下多明尼加隊投手保送首位打者山田哲人。日本隊護送山田上二壘，吉田正尚緊接著敲安，但拚回本壘的山田哲人，速度不敵多明尼加左外野手米賽斯（Johan Mieses）回傳，遭主審紀華文宣判觸殺出局。";
			return StringCore.Findstr( szTest, szFindStr );
		}

		[TestCase( "外野", "內野", Result = "8局下多明尼加隊投手保送首位打者山田哲人。日本隊護送山田上二壘，吉田正尚緊接著敲安，但拚回本壘的山田哲人，速度不敵多明尼加左內野手米賽斯（Johan Mieses）回傳，遭主審紀華文宣判觸殺出局。" )]
		[TestCase( "Johan Mieses", "Derek Jeter", Result = "8局下多明尼加隊投手保送首位打者山田哲人。日本隊護送山田上二壘，吉田正尚緊接著敲安，但拚回本壘的山田哲人，速度不敵多明尼加左外野手米賽斯（Derek Jeter）回傳，遭主審紀華文宣判觸殺出局。" )]
		[TestCase( "二壘，吉田", "aasdfg", Result = "8局下多明尼加隊投手保送首位打者山田哲人。日本隊護送山田上aasdfg正尚緊接著敲安，但拚回本壘的山田哲人，速度不敵多明尼加左外野手米賽斯（Johan Mieses）回傳，遭主審紀華文宣判觸殺出局。" )]
		[TestCase( "觸殺出局", "再見 home run", Result = "8局下多明尼加隊投手保送首位打者山田哲人。日本隊護送山田上二壘，吉田正尚緊接著敲安，但拚回本壘的山田哲人，速度不敵多明尼加左外野手米賽斯（Johan Mieses）回傳，遭主審紀華文宣判再見 home run。" )]
		[TestCase( "。", "！", Result = "8局下多明尼加隊投手保送首位打者山田哲人！日本隊護送山田上二壘，吉田正尚緊接著敲安，但拚回本壘的山田哲人，速度不敵多明尼加左外野手米賽斯（Johan Mieses）回傳，遭主審紀華文宣判觸殺出局。" )]

		[Test()]
		public string Replacetest( string szFinds, string szReplace )
		{
			string szTest = "8局下多明尼加隊投手保送首位打者山田哲人。日本隊護送山田上二壘，吉田正尚緊接著敲安，但拚回本壘的山田哲人，速度不敵多明尼加左外野手米賽斯（Johan Mieses）回傳，遭主審紀華文宣判觸殺出局。";
			StringCore.Replacestr( ref szTest, szFinds, szReplace, 0 );
			return szTest;
		}
	}
}
