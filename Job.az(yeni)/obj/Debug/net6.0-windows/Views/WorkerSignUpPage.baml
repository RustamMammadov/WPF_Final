   M S B A M L   `   `   `  ����G  CJob.az(yeni), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Job.az_yeni_.ViewsJob.az_yeni_.Views  5      )    #Job.az_yeni_.Views.WorkerSignUpPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Job.az_yeni_.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  WorkerSignUpPage��5
       N� 
Background
 ����� N� FontSize$ 30(�63   .��5      � $
��Auto=�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6   � 5      $ CornflowerBlue��6    � Offset$ 1Q�66   5       � RowDefinitions 5   
   �� 5      �� 5      $��4* �6   .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�6>   $��50(�6Y   $��Worker Sign Up Page��6g   $��Bahnschrift)�6�   6�   �� 5   
   $��1��6   .��5      �� $
��Auto=�6   $��20q�6J   $��1��6V    �� Orientation$ 
Horizontal=�6c   $��Center=�6|   .+�5      �� $	��320��6   $��24(�6(   
����ح�$	��350��6M   $��0,0,20,0q�6Y   $��Center=�6k   ��6�   �� *Worker.Username+.��5      �� .+�5      �� $ 
Horizontal=�6%   .+�5      �� .��6$   Name :6,   �� 5      $	��230��6&   .  (MaterialDesignThemes.Wpf.TextFieldAssist	   HasClearButton$
	 True��6O   ��62   �� *Worker.Name+6�   5      �� 5      $ 
Horizontal=�6%   .+�5       �� .��6$   	Surname :6/   �� 5!      $	��200��6&   $
	 True��6R   ��62   �� *Worker.Surname+6�   5"      �� 5#      $ 
Horizontal=�6%   .+�5$      �� .��6$   City :6,   �� 5%      $	��252��6&   $
	 True��6O   ��62   �� *Worker.City+6�   5&      �� 5'      $ 
Horizontal=�6%   .+�5(      �� .��6$   	Phone :6-   �� 5)      $	��230��6&   $
	 True��6P   ��62   �� *Worker.Phone+6�   5*      �� 5+      $ 
Horizontal=�6%   .+�5,      �� .��6$   BirthDate :61   (  "System.Windows.Controls.DatePicker  5-      $
��auto��6)   $
	 True��6X   
   Text
 66   �� *Worker.Birthdate+6�   5.      5/      50      �� 51      $	��320��6   
����ح�$	��350��6?   $��CV��6K   $��24(�6W   .��52      �� .+�53      �� $ 
Horizontal=�6%   .+�54      �� .��6$   	Major :6-   �� 55      $	��238��6I   $
	 True��6V   ��6&   �� *Worker.Cv.Ixtisas+6�   56      �� 57      $ 
Horizontal=�6%   .+�58      �� .��6$   
Skills :6.   �� 59      $	��200��6m   $
	 True��6y   ��6&   �� *Skill+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5:      $��30��6L   $��5q�6W   $��+��6c   ��6%   �� *AddToSkillsCommand+6q   �� 5;      ��6'   �� *Worker.Cv.Skills+6R   5<      �� 5=      $ 
Horizontal=�6%   .+�5>      �� .��6$   Companies :61   �� 5?      $	��135��6o   $
	 True��6|   ��6&   �� *	Company+$ TwoWay=�$ PropertyChanged=�6�   �� 5@      $��30��6P   $��5q�6\   $��+��6h   ��6%   �� *AddToCompaniesCommand+6v   �� 5A      ��6(   �� *Worker.Cv.Companies+5B      5C      �� 5D      $ 
Horizontal=�6%   .+�5E      �� .��6$   Languages :61   �� 5F      $	��140��6p   $
	 True��6}   ��6&   �� *
Language+$ TwoWay=�$ PropertyChanged=�6�   �� 5G      $��30��6O   $��5q�6Z   $��+��6f   ��6%   �� *AddToLanguagesCommand+6t   �� 5H      ��6'   �� *Worker.Cv.Languages+5I      5J      �� 5K      $ 
Horizontal=�6%   .+�5L      �� .��6$   	GitLink :6/   �� 5M      $	��230��6I   $
	 True��6V   ��6&   �� *Worker.Cv.GitLink+6�   5N      �� 5O      $ 
Horizontal=�6%   .+�5P      �� .��6$   
Linkedin :60   �� 5Q      $	��215��6J   $
	 True��6W   ��6&   �� *Worker.Cv.Linkedin+6�   5R      5S      5T      �� 5U      $	��320��6   $
��Auto��6'   $��20,0,0,0q�6T   ��64   �� *SaveCommand+.��6f   Save6l   5V      5W      5X      5Y      