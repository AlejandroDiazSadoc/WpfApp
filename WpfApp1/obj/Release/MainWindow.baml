   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��220��$	��430��$y�Visible=�  � 
ResizeMode$  NoResize=� � WindowStyle$
 None=� � AllowsTransparency . .���  � RowDefinitions �� $��30 ��� $��* �.+��� -   $��0��
������ ._�� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Accent=����	#FF106973.���� $��Right=� �� Orientation$ 
Horizontal=�.+��� -   $��30��$��30��$��0q����	#FF19AAB9.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=��� -   $��30��$��30��$��0q����	#FF19AAB9.��  $ WindowClose=�� $��1��
�������.+��� $ Vertical=�$��20,20,20.4,19.6q�$��2��.+��� $ 
Horizontal=�$��26��$��0,0,0,10q�.+�  $ Account=�$��26��$��0,0,2,0q�$��29��$��Bottom=�����  �� ElementName$ User_txt�� �� Path$ BorderBrush��� -   	 ��Name$	 User_txt��$	��360��$��
0,0,0,-0.4q�)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$

 User���� $ 
Horizontal=�$��26��$��0,0,0,10q�.+�  $	 Key=�$��26��$��0,0,2,0q�$��29��$��Bottom=����� $ Password_txt��$ BorderBrush�G� -    G�Name$ Password_txt��$	��360��$
 Password���� $ 
Horizontal=�$��Center=�.+��� -   $��Sign Up��$	��100��$��10q��� -   $��Login��$	��100��$��10q�#  MaterialDesignThemes.Wpf.Card  -     Name$ Login_Failed��$y�	Collapsed=�$��5q�$��0,0,0,5q�$	��150��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�.���� $ ��Incorrect User or Password��
���  ��)  #MaterialDesignThemes.Wpf.DialogHost  -	     Name$ Logged��   IsOpen .  $��2��$��0,0,0.4,-0.4q�   DialogContent �� $��60��$��20��.+��� $��	Logged In��
����� �