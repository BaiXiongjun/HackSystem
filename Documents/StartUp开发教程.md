> ### ��ʾ��Ŀ GitHub ��ַ : [RingsStartUp](https://github.com/CuteLeon/HackSystem/tree/master/RingsStartUp)
***

> ### 1>. �����ڽ�������������� StartUps ��������ļ������½���Ŀ��
    ��Ŀ����Ϊ Visual C#>Windows ��������>��� (.Net Framework)��
	��ܰ汾Ϊ .Net Framework 4.0��
***
> ### 2>. ������Ŀ���ԣ�
	����Ŀ¼����Ϊ��
	Debug => ..\Debug\StartUps\
	Release => ..\Release\StartUps\
***

> ### 3>. Ϊ��Ŀ������ã�
	������� => StartUpTemplate.dll
	�� ��Ŀ>���� ��ѡ��StratUpTemplate�����Դ����� ���Ʊ��� => false��
***

> ### 4>. ���ý��������Ŀ����
	Ϊ RingsStartUp ��Ŀ���� StartUpTeamplate ��Ŀ����
***

> ### 5>. ������ RingsStartUp ��Ϊ������ʾ��
	����Ŀ�ڽ��������StartUp���
***

> ### 6>. ��Ŀ ���>�½���>Visual C#>��Դ�ļ�
	����Ϊ RingsStartUpResource
***

> ### 7>. ��Ŀ���½��ļ��У���ֻ��������StratUp���ʱҲ���Բ��½��ļ��У�
	��Ϊ RainbowRing���� Class1 Ǩ�Ƶ����ļ����У�
	��Ҫע�� Class ���������ռ������ڽ���������㣬�� namespace RingsStartUp��
	������ Class1 ��Ϊ RainbowRingClass
	���Ҳ����Ϊ����� Type����
	RainbowRing �ļ������½� Form��
	����Ϊ RainbowRingForm
	���ƿռ��Ϊ namespace RingsStartUp��
***

> ### 8>. RainbowRingClass ������ StartUpTemplate
	RainbowRingClass �����������ռ� using StartUpTemplate��
	RainbowRingClass �̳в�ʵ�� StartUpTemplateClass �����ࣻ
	�ڹ��캯���ڸ�ֵ����� ���ơ�������Ԥ����
	ע�⣡
	�����ٹ��캯���� new �� Form����һ��Ҫ�� CreateStartUpForm �����ڷ�����Ч�� Form ����
``` csharp
using System.Windows.Forms;
using StartUpTemplate;

namespace RingsStartUp
{
	public class RainbowRingClass : StartUpTemplateClass
	{
		public RainbowRingClass()
		{
			Name = "�ʺ绷";
			Description = "�ʺ绷�������� - Leon";
			Preview = RingsStartUpResource.RainbowStartUpPreview;
		}

		protected override Form CreateStartUpForm()
		{
			return new RainbowRingForm() { ParentStartUp  =this };
		}
	}
}
```
***

> ### 9>. RainbowStartUpForm ���� StartUpTemplateClass �����ֶ�
	public StartUpTemplateClass ParentStartUp = null;
	���ڼ�¼�������� StartUp
***

> ### 10>. ���������������ϲ���� StartUp ����
***

> ### 11>. ��������¼�
	�������������ɺ�Ҫ���� ParentStartUp.OnStartUpFinished(s, e);
	���ر� StartUpForm��
	�򵥵�ʵ�ַ�����
``` csharp
public RainbowRingForm()
{
    InitializeComponent();
    CheckForIllegalCrossThreadCalls = false;
    this.FormClosing += new FormClosingEventHandler((Leon, Mathilda) => { ParentStartUp?.OnStartUpFinished(EventArgs.Empty); });
}
```

    �����ؽ���ʱ��
``` csharp
ThreadPool.QueueUserWorkItem(new WaitCallback(
    (ILoveU) => {
        while (this.Opacity > 0)
        {
            Thread.Sleep(100);
            this.Opacity -= 0.1;
        }

        this.Close();
    }));
```
***

12>. ʹ�ò����
	������ HackSystem �������洦����ʹ�ô� StartUp �����
	Ҳ����ֱ���޸� Config �ļ���ʹ�ô� StartUp �����
``` xml
<add key="StartUpFile" value="RingStartUp.dll" />
<add key="StartUpName" value="RainbowRingClass" />
```

***

> ### ����
via : Leon.ID#QQ.COM