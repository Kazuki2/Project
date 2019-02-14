using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class TestList
{
    public List<Test> Data { get; }
    
    // コンストラクタ(データ入力)
    public TestList()
    {
        Data = new List<Test> {
                new Test { Subj="国語", Points=90, Name="田中　一郎", ClassName="A" },
                new Test { Subj="数学", Points=50, Name="鈴木　二郎", ClassName="A" },
                new Test { Subj="英語", Points=90, Name="佐藤　三郎", ClassName="B" }
            };
    }
}