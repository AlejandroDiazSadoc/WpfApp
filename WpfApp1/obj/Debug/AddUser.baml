   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.AddUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   $	��280��5	   
   $	��500��6     � 
ResizeMode$  NoResize=�6#    � WindowStyle$
 None=�69   .��5
      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��20,20,20.4,19.6q�6,   .+�5      �� $ 
Horizontal=�6   $��26��62   $��0,0,0,10q�6>   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   $��26��69   $��0,0,2,0q�6E   $��29��6V   $��Bottom=�6�   ��6a   ��  �� ElementName$ UserName_txt�� �� Path$ BorderBrush�6�   �� 5      -   5         ��Name$ UserName_txt��5      $	��360��60   $��
0,0,0,-0.4q�6<   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 User��6P   5      �� 5      $ 
Horizontal=�6   $��26��62   $��0,0,0,10q�6>   .+�5        $	 Key=�6*   $��26��65   $��0,0,2,0q�6A   $��29��6R   $��Bottom=�6�   ��6]   �� $ Password1_txt��$ BorderBrush�6�   G� 5      -   5         G�Name$ Password1_txt��5      $	��360��65   $ Password��6B   5      �� 5      $ 
Horizontal=�6   $��26��62   $��0,0,0,10q�6>   .+�5        $	 Key=�6*   $��26��65   $��0,0,2,0q�6A   $��29��6R   $��Bottom=�6�   ��6]   �� $ Password2_txt��$ BorderBrush�6�   G� 5      -   5        $ Password2_txt��5      $	��360��65   $ Repeat Password��6B   5      �� 5      $ 
Horizontal=�6   $��45��62   $��0,0,0,10q�6>   .+�5      �� $
��Role��6   $��Center=�6(   $��0,0,15,0q�6C   $��15(�6U   �� 5      -   5        	 ��Name$	 
RolePicker��5      $��10q�60   $��90��6<   $��25��6G   
���   �.@�5       �� 
 �� 
IsSelected
 . .��65   user6;   �� 5!      .��6$   admin6+   5"      5#      �� 5%      $ 
Horizontal=�6   $��Center=�62   .+�5&      �� -   5        $
��Back��5&      $	��100��6(   $��10q�6C   �� 5'      -   5        $��Add User��5'      $	��100��6,   $��10q�6K   5(      #  MaterialDesignThemes.Wpf.Card  5+      -   5          Name$ AddUser_Failed��5+   "   $y�	Collapsed=�6:   $��5q�6Q   $��0,0,0,5q�6]   $	��250��6n   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6z   .��5,      �� -   5         ��Name$ AddUser_Failed_Text��5,      
���  ��69   5-      5/      51      52      