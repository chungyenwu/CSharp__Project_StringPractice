using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice4
{
	//public member and method
	public partial class StringUI : Form
	{

		public StringUI()
		{
			InitializeComponent();
			StringForm = new StringPrac();
		}
	}

	//private member ans method
	public partial class StringUI : Form
	{
		string m_szTemp1;
		StringPrac StringForm;
		int m_nClickNumber;
		int[] m_nIndexArray = new int[ 100 ];

		private void Find_btn_Click( object sender, EventArgs e )
		{

			m_txtContext.SelectAll();
			m_txtContext.SelectionBackColor = Color.White;
			m_txtContext.SelectionColor = Color.Black;
			string szText = m_txtContext.Text;
			string szF = m_txtFind.Text;

			if( m_szTemp1 != m_txtFind.Text ) {
				m_nClickNumber = 0;
			}
			if( m_szTemp1 == m_txtFind.Text ) {
				m_nClickNumber++;
			}

			// Step 1.Find the string
			if( StringForm.Findstr( szText, szF ) == false ) {
				MessageBox.Show( "找不到" );
			}
			if( StringForm.Findstr( szText, szF ) == true ) {

				if( m_szTemp1 != m_txtFind.Text ) {
					m_nIndexArray = StringForm.FindPosition( szText, szF );
				}

				if( m_nIndexArray.Length - 1 > m_nClickNumber ) {
					m_txtContext.Select( m_nIndexArray[ m_nClickNumber ], szF.Length );
					m_txtContext.SelectionBackColor = Color.Black;
					m_txtContext.SelectionColor = Color.White;
				}

				if( m_nIndexArray.Length - 1 == m_nClickNumber ) {
					m_nClickNumber = m_nClickNumber - 1;
					m_txtContext.Select( m_nIndexArray[ m_nClickNumber ], szF.Length );
					m_txtContext.SelectionBackColor = Color.Black;
					m_txtContext.SelectionColor = Color.White;
					MessageBox.Show( "沒了" );
				}
				if( m_nIndexArray.Length - 1 < m_nClickNumber ) {
					MessageBox.Show( "沒了" );
				}
			}
			m_szTemp1 = m_txtFind.Text;
		}

		private void Replace_btn_Click( object sender, EventArgs e )
		{
			string szText1 = m_txtContext.Text;
			string szF1 = m_txtFind.Text;
			string szR1 = m_txtReplace.Text;
			int[] nIndexArray1 = m_nIndexArray;
			if( m_txtContext.SelectionBackColor == Color.Black ) {
				szText1 = szText1.Remove( nIndexArray1[ m_nClickNumber ], szF1.Length );
				szText1 = szText1.Insert( nIndexArray1[ m_nClickNumber ], szR1 );
			}
			m_txtContext.Text = szText1;
		}
	}
}