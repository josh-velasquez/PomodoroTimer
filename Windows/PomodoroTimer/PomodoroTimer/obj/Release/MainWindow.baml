   M S B A M L   `   `   `  ����   PomodoroTimer    PomodoroTimer.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    >d2http://schemas.microsoft.com/expression/blend/2008    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ CanMinimize=� � Title$ Pomodoro Timer��$��291.833��$��410.332��.��� ���	#FF264653.+��� -    ��Name$ StartButton��$��Start��$
��Left=�$��
10,176,0,0q�$	��Top=�$	��375��$��30�����	#FF2A9D8F
�����������  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R���  ��Name$ Border��#��z��._��� $��Center=�$��Center=�	 �� Triggers	 P� 
 P� Property
 �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ Border�� � �� �#219ebc � 	Resources ��%9   '��       �� " ��.���  �@��CornerRadius$ 4���� -   $
��Work��$
��Left=�$��
10,141,0,0q�$	��Top=�$��30��$��90�����	#FFF4A261
����������� " ��.���  � �� �� " ��.R��� $ Border��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ��� $ Border�� � �� �#219ebc ��%9   '��       �� " ��.���  �@��CornerRadius$ 4���� -   $��Short Break��$
��Left=�$��105,141,0,0q�$	��Top=�$��30��$��90�� J� RenderTransformOrigin$ 0.167,-3.65&����	#FFF4A261
����������� " ��.���  � �� �� " ��.R��� $ Border��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ��� $ Border�� � �� �#219ebc ��%9   '��       �� " ��.���  �@��CornerRadius$ 4���� -   $��
Long Break��$
��Left=�$��200,141,0,0q�$	��Top=�$��30��$��90�����	#FFF4A261
����������� " ��.���  � �� �� " ��.R��� $ Border��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ��� $ Border�� � �� �#219ebc ��%9   '��       �� " ��.���  �@��CornerRadius$ 4���� -   $��Pause��$
��Left=�$��
10,211,0,0q�$	��Top=�$	��375��$��30�����	#FFE9C46A
����������� " ��.���  � �� �� " ��.R��� $ Border��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ��� $ Border�� � �� �#219ebc ��%9   '��       �� " ��.���  �@��CornerRadius$ 4���� -    ��Name$ TimerTextBlock�� �� TextAlignment$ Center=�$��	10,10,0,0q�$
��Wrap=�$��85(�$��00:00��$	��Top=�$	��126�����	#FFE76F51���	#FF023047$
��Left=�$	��375���� -   $��Custom Break��$
��Left=�$��295,141,0,0q�$	��Top=�$��30��$��90�����	#FFF4A261
�������{�.  ���� " ��.���  � �� �� " ��.R��� $ Border��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ��� $ Border�� � �� �#219ebc ��%9   '��       �� " ��.���  �@��CornerRadius$ 4���� $
��Left=�$��222,109,0,0q�$
��Wrap=�$��Seconds��$	��Top=�$��68��$
��Bold"�$��Sitka Subheading)�$��16(��� $
��Left=�$��111,109,0,0q�$
��Wrap=�$��Minutes��$	��Top=�$��68��$
��Bold"�$��Sitka Subheading)�$��16(�