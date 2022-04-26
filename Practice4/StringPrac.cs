using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4
{
	class StringPrac
	{
		public bool Findstr( string szContext, string szFind )
		{
			if( szContext.IndexOf( szFind ) == -1 ) {
				return false;
			}
			return true;
		}
		public int[] FindPosition( string szContext, string szFind )
		{
			bool bResult = szContext.Contains( szFind );
			if( bResult == false ) {
				return new int[] { -1 };
			}

			int nStart = 0;
			int nCount = szContext.Length;
			int nStrlen = szFind.Length;

			string[] szArray = szContext.Split( new string[] { szFind }, StringSplitOptions.None );
			int nFindNumber = szArray.Length;
			int[] nFindArray = new int[ nFindNumber ];

			for( int n = 0; n < nFindNumber - 1; n++ ) {
				int nIndex = szContext.IndexOf( szFind, nStart, nCount );
				nStart = nIndex + nStrlen;
				nCount = szContext.Length - nStart;
				nFindArray[ n ] = nIndex;
			}
			return nFindArray;
		}

		public void Replacestr( ref string szContext, string szFind, string szReplace, int nIndex )
		{
			int[] nIndexArray = FindPosition( szContext, szFind );
			szContext = szContext.Remove( nIndexArray[ nIndex ], szFind.Length );
			szContext = szContext.Insert( nIndexArray[ nIndex ], szReplace );
		}
	}
}
