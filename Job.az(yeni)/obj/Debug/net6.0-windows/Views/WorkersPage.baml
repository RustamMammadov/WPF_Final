   M S B A M L   `   `   `  ����G  CJob.az(yeni), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Job.az_yeni_.ViewsJob.az_yeni_.Views  5      $    Job.az_yeni_.Views.WorkersPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Job.az_yeni_.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  WorkersPage��5
       N� FontSize$ 18(�6   .��5      � $��8q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6   � 5      $ CornflowerBlue��6    � Offset$ 1Q�66   5       � RowDefinitions 5   
   �� 5      �� 5      $��6* �6   .+�5   
   � $	��450��6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� $��5q�6   $��0��6   $��Center=�6/   $��Center=�6J   .��6g   	Major :6p   �� 5      $��5q�6   $��1��6!   $��40��6I   $	��128��6U   $��2q�6a   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6v   ��61   �� *Search+6�   �� 5      $��5q�6   $��2��6    $	��100��6R   ��60   �� *SearchCommand+.��6^   Search6f   5      �� 5    
   -   5        $��
WorkerList��5       $��1��6u   	 �� SelectedItem	 6%   �� *Worker+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *TempWorkers+��5!      �� 5"      .R�5#      � 6"   5$      ��5&      �� 5'      .R�5(      �� $	��350��6   
����ح���6+   �� *
Username+.��5)      �� .+�5*      ��  �� Orientation$ 
Horizontal=�6)   .+�5+   "   �� .��6(   Name :60   �� 5,   "   $
��auto��6B   $
 True��6P   ��6,   �� *Name+6�   5-      �� 5.      $ 
Horizontal=�6)   .+�5/   "   �� .��6(   	Surname :63   �� 50   "   $
��auto��6E   $
 True��6S   ��6,   �� *	Surname+6�   51      �� 52      $ 
Horizontal=�6)   .+�53   "   �� .��6(   City :60   �� 54   "   $
��auto��6B   $
 True��6P   ��6,   �� *City+6�   55      �� 56      $ 
Horizontal=�6)   .+�57   "   �� .��6(   	Phone :61   �� 58   "   $
��auto��6C   $
 True��6Q   ��6,   �� *Phone+6�   59      �� 5:      $ 
Horizontal=�6)   .+�5;   "   �� .��6(   BirthDate :65   �� 5<   "   $
��auto��6G   $
 True��6U   ��6,   �� *	BirthDate+6�   5=      �� 5>      $ 
Horizontal=�6)   .+�5?   "   �� .��6(   	Major :61   �� 5@   "   $
��auto��6H   $
 True��6V   ��6,   �� *
Cv.Ixtisas+6�   5A      �� 5B      $ 
Horizontal=�6)   .+�5C   "   �� .��6(   Languages :65   �� 5D   "   $
��auto��6P   $
 True��6^   ��6+   �� *Cv.Languages+6�   5E      �� 5F      $ 
Horizontal=�6)   .+�5G   "   �� .��6(   Companies :65   �� 5H   "   $
��auto��6P   $
 True��6^   ��6+   �� *Cv.Companies+6�   5I      �� 5J      $ 
Horizontal=�6)   .+�5K   "   �� .��6(   
Skills :62   �� 5L   "   $
��auto��6M   $
 True��6[   ��6+   �� *	Cv.Skills+6�   5M      �� 5N      $ 
Horizontal=�6)   .+�5O   "   �� .��6(   	GitLink :63   �� 5P   "   $
��auto��6H   $
 True��6V   ��6,   �� *
Cv.GitLink+6�   5Q      �� 5R      $ 
Horizontal=�6)   .+�5S   "   �� .��6(   
Linkedin :64   �� 5T   "   $
��auto��6I   $
 True��6W   ��6,   �� *Cv.Linkedin+6�   5U      �� 5V      $ Vertical=�6)   .+�5X   "   �� $��Invite��5Y   �   $	��150��6�   $
 True��6�   {�5X   )   ��  �� Path$ 
IsSelected� �� RelativeSource �� *FindAncestor+ �� AncestorType" ����5Y   w   �� *DataContext.InviteCommand+ �� ElementName$ 
WorkerList��6  5Z      5[      5\      5]      5_      5`      5a      