   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.LoggedIn   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��600��$	��970��  � 
ResizeMode$  NoResize=� � WindowStyle$
 None=�
������� � Cursor$
 Hand�� � 	Resources    MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$ 50Q�  $ 0:0:0.5��$	 150Q�U� $ (FrameworkElement.Width)�$ ContentGrid��.\�  $ 0��$	 920Q�  $ 0:0:0.5��$	 820Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 150Q�  $ 0:0:0.5��$ 50Q�U� $ (FrameworkElement.Width)�$ ContentGrid��.\�  $ 0��$	 820Q�  $ 0:0:0.5��$	 920Q� � Triggers :� 	 :� RoutedEvent$	 ButtonBase.Click��
 :� 
SourceName$
 ButtonOpenMenu��.[��� #��[  :� $	 ButtonBase.Click��$
 ButtonCloseMenu��.[��� #��[ .��� .+�� -   $��60��$	��Top=����	#FF02DC02.+��� $��Center=� �� Orientation$ 
Horizontal=�$��Right=�.+��� -    ��Name$ UserName��
�������$��Center=�$��15(�'  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�$��10q�   PlacementMode$ BottomAndAlignRightEdges=�
�������   	StaysOpen .     PopupContent. �� $	��100��.+��� -    ��Name$ UserProfile��$��Profile���� -   $ LogoutButton��$��Logout���� -   $ ExitApp��$
��Exit��� -    �Name$ GridMenu��$��50��$
��Left=�
��� d �.+��� .+�� $	��120��
�������.+��� -   $ ButtonCloseMenu��$��60��$��60��$��Right=�$	��Top=�$y�	Collapsed=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�
��� d �$��35��$��35���� -   $ ButtonOpenMenu��$��60��$��60��$��Right=�$	��Top=���Z� ��Z� .��  $
 Menu=�
��� d �$��35��$��35���� $��Disabled=����	#FF02DC02.@��� $��60��.���� -	    ��Name$ HomeContent��$ 
Horizontal=�.+�  $
 Home=�$��Center=�$��25��$��25���� $
��Home��$��20 10q�$��Center=�
��������� -
    ��Name$ UserContentMenu��$��60��$y�	Collapsed=�.���� -   $ UserContent��$ 
Horizontal=�.+�  $
 User=�$��Center=�$��25��$��25���� $��Users��$��20 10q�$��Center=�
��������� $��60��.���� -   $ BooksContent��$ 
Horizontal=�.+�  $ BookAccount=�$��Center=�$��25��$��25���� $��Books��$��20 10q�$��Center=�
��������� $��60��.���� -   $ GithubContent��$ 
Horizontal=�.+�  $ Github=�$��Center=�$��25��$��25���� $��Github��$��20 10q�$��Center=�
�������� -   $ ContentGrid��$	��540��$	��920��$��Right=�$��Bottom=�.+�)  #MaterialDesignThemes.Wpf.DialogHost  -     Name$ 	LoggedOut��   IsOpen .  $��2��$��0,0,0.4,-0.4q�   DialogContent �� $	��400��$	��100��.+��� $��Goodbye!��$��45(�$��Center=�
����� �  -   $ EditBookContent�� .  $��2��$��0,0,0,0q� �� $ Vertical=�$��20,20,20.4,19.6q�$��2��.+��� $ 
Horizontal=�$��26��$��0,0,0,10q�.+��� $��Title���� -    ��Name$ EditTitle_txt��$	��360��$��
0,0,0,-0.4q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Title..���� $ 
Horizontal=�$��26��$��0,0,0,10q�.+��� $��	Publisher���� -   $ EditPublisher_txt��$	��360��$ Publisher..���� $ 
Horizontal=�$��45��$��0,0,0,10q�.+��� $��isRented��$��Center=��� -    ��Name$ RentedPicker��$��10q�$��90��$��35��
���   �.@��� .��true�� .��false�� $ 
Horizontal=�$��26��$��0,0,0,10q�.+��� $��User Rented���� -   $ EditUserRented_txt��$	��360��$ User rented..���� $ 
Horizontal=�$��Center=�.+��� -   $ 
CancelEdit��$��Cancel��$	��100��$��10q��� -   $ SaveEdit��$
��Save��$	��100��$��10q�#  MaterialDesignThemes.Wpf.Card  -     Name$ AddBook_Failed��$y�	Collapsed=�$��5q�$��0,0,0,5q�$	��250��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�.���� -   $ AddBook_Failed_Text��
���  ���� -   $ 	HomePanel��$	��540��.+��� $��Welcome!��$��	0,150,0,0q�$��80(�$��Center=����	#FF02DC02�� -   $ 
BooksPanel��$	��540��$y�	Collapsed=�.+�� $��Stretch=�$��Stretch=�.+��� -    ��Name$ lvBooks��$��10q� �� View �� .P��� $��Title�� �� Width$	 100��  �� DisplayMemberBinding  �� *title+�� $��	Publisher��$	 120��  �� *	publisher+�� $��isRented��$	 100��  �� *
isRented+�� $��User Rented��$	 150��  �� *
userRented+�� $��Actions��$	 250��! �� CellTemplate! �� DataTemplatePanel��.R��� $ ActionBookButtons��-   $ 
Horizontal=�.+��� $ RentBook_Button��-   $
��Rent��$��2q��� $ DeleteBook_Button��-   $y�	Collapsed=�$��Delete��$��2q��� $ EditBook_Button��-   $y�	Collapsed=�$
��Edit��$��2q���   Z� .���� -    $ PanelAddBook��$ 
Horizontal=�.+��� -!   $ AddBook_Button��$y�Hidden=�$��Add Book��$	��100��! �� �� -"   $ 	UserPanel��$	��540��$y�	Collapsed=�.+�� $��Stretch=�$��Stretch=�.+��� -#   $ lvUsers��$��10q� �� .P��� $��Username��$	 150��  �� *
username+�� $��Password��$	 150��  �� *
password+�� $
��Role��$	 100��  �� *role+�� $��Actions��$	 220��! �� .R��� $ 
Horizontal=�.+��� $ DeleteUser_Button��-$   $��2q�$��Delete��$��80���� $ ChangeUser_Button��-%   $��2q�$��Change Role��$	��120����   Z� .���� -&   $ AddUser_Button��$��Add User��$��90��! �� �� -'   $ GithubPanel��$y�Hidden=�$	��540��.+�(  "System.Windows.Controls.WebBrowser  -(   "  Name$" BrowserPage��#   Source$+# %https://github.com/AlejandroDiazSadoc?�$	��540���� -)   $ ProfilePanel��$ Vertical=�$��Center=�$��Center=�$y�	Collapsed=�.+��� $ 
Horizontal=�$��26��$��0,0,0,10q�.+�  $ Account=�$��26��$��0,0,2,0q�$��29��$��Bottom=����� $ �� ElementName$$ UserNameProfile_txt��% �� Path$% BorderBrush��� -*   $ UserNameProfile_txt��$	��360��$��
0,0,0,-0.4q�$
 User���� $ 
Horizontal=�$��26��$��0,0,0,10q�.+�  $	 Key=�$��26��$��0,0,2,0q�$��29��$��Bottom=����� $$ PasswordProfile_txt��$% BorderBrush��� -+   $ PasswordProfile_txt��$	��360��$ Password���� $ 
Horizontal=�$��45��$��0,0,0,10q�.+��� $
��Role��$��Center=�$��0,0,15,0q�$��15(��� -,   $ RoleUserProfile��$��15(�$��Center=��� $ 
Horizontal=�$��Center=�.+��� --   $��Save Changes��$��10q�  -.   $ SaveUser_Failed��$y�	Collapsed=�$��5q�$��0,0,0,5q�$	��250��$ Depth4=�.���� -/   $ SaveUser_Failed_Text��
���  ��