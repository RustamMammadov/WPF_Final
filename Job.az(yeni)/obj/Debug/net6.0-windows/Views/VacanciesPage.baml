   M S B A M L   `   `   `  ����G  CJob.az(yeni), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Job.az_yeni_.ViewsJob.az_yeni_.Views  5      &     Job.az_yeni_.Views.VacanciesPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Job.az_yeni_.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  VacanciesPage��5
       N� FontSize$ 20(�6   .��5      � $��10q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6   � 5      $ CornflowerBlue��6    � Offset$ 1Q�66   5       � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��10* �6   .+�5   
   �� $��10q�6   $	��200��6C   $��Add Vacancy��6O   ��6   �� *AddVacancyCommand+6g   �� 5   
   -   5        $��VacancyList��5      $��1��6w    �� SelectedItem 6&   �� *	Vacancy+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=���6�   �� *	Vacancies+��5      �� 5      .R�5      � 6"   5      ��5      �� 5      .R�5      �� 
����ح�$	��490��66   $��Vacancy��6B   .��5       �� .+�5!      �� 
 �� Orientation$
 
Horizontal=�6)   .+�5"   "   �� .��6(   	Major :61   �� 5#   "   $
��auto��6B   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6P   ��6,   �� *Name+6�   5$      �� 5%      $
 
Horizontal=�6)   .+�5&   "   �� .��6(   
Salary :62   �� 5'   "   $
��auto��6D   $
 True��6R   ��6,   �� *Salary+6�   5(      �� 5)      $
 
Horizontal=�6)   .+�5*   "   �� .��6(   Description :67   �� 5+   "   $
��auto��6I   $
 True��6W   ��6,   �� *Description+6�   5,      �� 5-      $
 
Horizontal=�6)   .+�5.   "   �� .��6(   
Appliers :64   �� 5/   "   $	��100��50   �   $
 True��6�   {�5/   )   ��  �� Path$ 
IsSelected� �� RelativeSource �� *FindAncestor+ �� AncestorType" ����50   w   �� *!DataContext.OpenAppliersCommand+ �� ElementName$ VacancyList����6�   �� *Workers.Count+6*  51      52      53      54      56      57      58      