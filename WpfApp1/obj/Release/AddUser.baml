   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.AddUser   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��280��$	��500��  � 
ResizeMode$  NoResize=� � WindowStyle$
 None=�.��� .+���  �� Orientation$ Vertical=�$��20,20,20.4,19.6q�.+��� $ 
Horizontal=�$��26��$��0,0,0,10q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�$��26��$��0,0,2,0q�$��29��$��Bottom=�����  �� ElementName$ UserName_txt�� �� Path$ BorderBrush��� -    ��Name$ UserName_txt��$	��360��$��
0,0,0,-0.4q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 User���� $ 
Horizontal=�$��26��$��0,0,0,10q�.+�  $	 Key=�$��26��$��0,0,2,0q�$��29��$��Bottom=����� $ Password1_txt��$ BorderBrush�G� -    G�Name$ Password1_txt��$	��360��$ Password���� $ 
Horizontal=�$��26��$��0,0,0,10q�.+�  $	 Key=�$��26��$��0,0,2,0q�$��29��$��Bottom=����� $ Password2_txt��$ BorderBrush�G� -   $ Password2_txt��$	��360��$ Repeat Password���� $ 
Horizontal=�$��45��$��0,0,0,10q�.+��� $
��Role��$��Center=�$��0,0,15,0q�$��15(��� -   	 ��Name$	 
RolePicker��$��10q�$��90��$��25��
���   �.@��� 
 �� 
IsSelected
 . .��user�� .��admin�� $ 
Horizontal=�$��Center=�.+��� -   $
��Back��$	��100��$��10q��� -   $��Add User��$	��100��$��10q�#  MaterialDesignThemes.Wpf.Card  -     Name$ AddUser_Failed��$y�	Collapsed=�$��5q�$��0,0,0,5q�$	��250��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�.���� -    ��Name$ AddUser_Failed_Text��
���  ��