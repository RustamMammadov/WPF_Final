   M S B A M L   `   `   `  ����G  CJob.az(yeni), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Job.az_yeni_.ViewsJob.az_yeni_.Views  5      '    !Job.az_yeni_.Views.WorkerMainPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Job.az_yeni_.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  WorkerMainPage��5
       N� 
Background
 ����� N� FontSize$ 25(�61   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6   � 5      $ CornflowerBlue��6    � Offset$ 1Q�66   5      .+�5   
   � $��10q�6    � RowDefinitions 5      �� 5      $��3* �6    �� 5      $��6* �6    .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� .+�5      �� 	 �� Orientation$	 
Horizontal=�6!   .+�5      �� .��6    MinSalary :6.   �� 5       $	��108��6=   ��6"   �� *	MinSalary+6K   5!      �� 5"      $	 
Horizontal=�6!   .+�5#      �� .��6    MaxSalary :6-   �� 5$      $	��108��6=   ��6"   �� *	MaxSalary+6K   5%      �� 5&      $	 
Horizontal=�6!   .+�5'      �� .��6    	Major :6)   �� 5(      $	��160��6:   ��6"   �� *Search+6H   5)      5*      �� 5+      $��1��6   ��6)   �� *SearchCommand+.��6K   Search6S   �� 5,      $��10q�6   $��2��6%   $��Right=�6b   $	��150��6~   ��65   �� *ShowNotificationsCommand+��6�   �� *NotificationCount+6�   5-      �� 5/      -   5        $��VacancyList��5/   ;   $��24(�6   
����ح�$��1��6�   
 �� SelectedItem
 6N   �� *	Vacancy+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *TempVacancies+��50      �� 51      .R�52      � 6&   53      ��55      �� 56      .R�57      �� $	��350��6#   $��Vacancy��6/   .��58      �� .+�59   "   �� $	 
Horizontal=�6-   .+�5:   &   �� .��6,   	Major :65   �� 5;   &   $
��auto��6F   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6T   ��60   �� *Name+6�   5<   #   �� 5=   "   $	 
Horizontal=�6-   .+�5>   &   �� .��6,   
Salary :66   �� 5?   &   $
��auto��6H   $
 True��6V   ��60   �� *Salary+6�   5@   #   �� 5A   "   $	 
Horizontal=�6-   .+�5B   &   �� .��6,   Description :6;   �� 5C   &   $
��auto��6M   $
 True��6[   ��60   �� *Description+6�   5D   #   �� 5E   "   $	 
Horizontal=�6-   $��Center=�6F   .+�5G   &   �� $��Apply��5H   �   $	��100��6�   $
 True��6�   {�5G   -   ��  �� Path$ 
IsSelected� �� RelativeSource �� *FindAncestor+ �� AncestorType" ����5H   w   �� *DataContext.ApplyCommand+ �� ElementName$ VacancyList��6  5I   #   5J      5K      5L      5N      5O      5P      5Q      