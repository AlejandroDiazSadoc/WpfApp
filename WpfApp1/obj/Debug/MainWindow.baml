   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��220��5	   	   $	��430��6   $y�Visible=�6"     � 
ResizeMode$  NoResize=�67    � WindowStyle$
 None=�6M    � AllowsTransparency . .��5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��0��5      
������ ._�5      � .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Accent=�6+   ���	#FF106973.��5      �� $��Right=�6!    �� Orientation$ 
Horizontal=�6=   .+�5      �� -   5        $��30��5   !   $��30��6,   $��0q�68   ���	#FF19AAB9.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowMinimize=�66   5      �� 5      -   5        $��30��5   !   $��30��6,   $��0q�68   ���	#FF19AAB9.��5        $ WindowClose=�66   5      5      5      5      5       � 5"   
   $��1��6   
�������.+�5$      �� $ Vertical=�6   $��20,20,20.4,19.6q�60   $��2��6I   .+�5&      �� $ 
Horizontal=�6   $��26��66   $��0,0,0,10q�6B   .+�5'        $ Account=�6.   $��26��6=   $��0,0,2,0q�6I   $��29��6Z   $��Bottom=�6�   ��6e   ��  �� ElementName$ User_txt�� �� Path$ BorderBrush�6�   �� 5(      -   5        	 ��Name$	 User_txt��5(      $	��360��60   $��
0,0,0,-0.4q�6<   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$

 User��6P   5)      �� 5+      $ 
Horizontal=�6   $��26��66   $��0,0,0,10q�6B   .+�5,        $	 Key=�6.   $��26��69   $��0,0,2,0q�6E   $��29��6V   $��Bottom=�6�   ��6a   �� $ Password_txt��$ BorderBrush�6�   G� 5-      -   5         G�Name$ Password_txt��5-   "   $	��360��68   $
 Password��6E   5.      �� 50      $ 
Horizontal=�6   $��Center=�66   .+�51      �� -   5        $��Sign Up��51      $	��100��6/   $��10q�6L   �� 52      -   5        $��Login��52      $	��100��6-   $��10q�6G   53      #  MaterialDesignThemes.Wpf.Card  56      -   5          Name$ Login_Failed��56   &   $y�	Collapsed=�6<   $��5q�6S   $��0,0,0,5q�6_   $	��150��6p   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6|   .��57      �� $ ��Incorrect User or Password��6    
���  ��6B   58      59      )  #MaterialDesignThemes.Wpf.DialogHost  5;      -	   5          Name$ Logged��5;   7      IsOpen .  $��2��6G   $��0,0,0.4,-0.4q�6[      DialogContent 5<      �� 5=      $��60��6!   $��20��6,   .+�5>      �� $��	Logged In��6$   
����� �6M   5?      5A      5C      5E      5F      