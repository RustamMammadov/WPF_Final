   M S B A M L   `   `   `  ����G  CJob.az(yeni), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Job.az_yeni_.ViewsJob.az_yeni_.Views  5      +    %Job.az_yeni_.Views.EmployerSignUpPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ,local clr-namespace:Job.az_yeni_.Views  5        N� Title$  EmployerSignUpPage��5
       N� 
Background
 ����� N� FontSize$ 30(�65   .��5      � $
��Auto=�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	LightBlue��6   � 5      $ CornflowerBlue��6    � Offset$ 1Q�66   5       � RowDefinitions 5   
   �� 5      �� 5      $��4* �6   .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�6>   $��50(�6Y   $��Employer Sign Up Page��6g   $��Bahnschrift)�6�   6�   �� 5   
   $��1��6   .��5      �� $
��Auto=�6   $��20q�6I   $��1��6U    �� Orientation$ 
Horizontal=�6b   $��Center=�6{   .+�5      �� $��24(�6   $	��300��6)   
����ح�$	��300��6M   $��0,0,20,0q�6Y   $��Center=�6k   ��6�   �� *Employer.Username+.��5      �� .+�5      �� $ 
Horizontal=�6%   .+�5      �� .��6$   Name :6,   �� 5      $
��auto��6&   .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton$
	 True��6R   ��63   �� *Employer.Name+6�   5      �� 5      $ 
Horizontal=�6%   .+�5       �� .��6$   	Surname :6/   �� 5!      $
��auto��6&   $
	 True��6U   ��63   �� *Employer.Surname+6�   5"      �� 5#      $ 
Horizontal=�6%   .+�5$      �� .��6$   	Phone :6-   �� 5%      $
��auto��6&   $
	 True��6S   ��63   �� *Employer.Phone+6�   5&      �� 5'      $ 
Horizontal=�6%   .+�5(      �� .��6$   BirthDate :61   (  "System.Windows.Controls.DatePicker  5)      $
��auto��6)   $
	 True��6Z   
   Text
 66   �� *Employer.Birthdate+6�   5*      5+      5,      �� 5-      $��24(�6   $	��300��6)   $	��300��65   $��Vacancy��6B   
����ح�.��5.      �� .+�5/      �� $ 
Horizontal=�6%   .+�50      �� .��6$   Major:6,   �� 51      $
��auto��6D   $
	 True��6R   ��6&   �� *Vacancy.Name+6�   52      �� 53      $ 
Horizontal=�6%   .+�54      �� .��6$   
Salary :6.   �� 55      $
��auto��6F   $
	 True��6T   ��6&   �� *Vacancy.Salary+6�   56      �� 57      $ 
Horizontal=�6%   .+�58      �� .��6$   Description :63   �� 59      $
��auto��6K   $
	 True��6Y   ��6&   �� *Vacancy.Description+6�   5:      5;      5<      �� 5=      $	��300��6   $��20q�6F   ��6&   �� *SaveCommand+.��6S   Save6Y   5>      5?      5@      5A      