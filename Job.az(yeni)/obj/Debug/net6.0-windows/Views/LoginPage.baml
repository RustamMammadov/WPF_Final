   M S B A M L   `   `   `  ����G  CJob.az(yeni), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Job.az_yeni_.ViewsJob.az_yeni_.Views  5      "    Job.az_yeni_.Views.LoginPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Job.az_yeni_.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	LoginPage��5
       N� 
Background
 ��ح�.��5      �� $��Center=�6   $��Center=�6,   .+�5   
   �� $��20q�6    �� Orientation$ 
Horizontal=�6!   .+�5      �� $��20(�6   .��6"   
Username :6.   �� 5      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��6\   $	��128��6�   ��6   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      �� 5   
   $��20q�6   $ 
Horizontal=�6!   .+�5      �� $��20(�6   .��6"   
Password :6.   �� 5      -   5         ��Name$ PasswordBox��5      $	��128��5   `   $
 True��5      ��5      �� *
Password+$ TwoWay=�$ PropertyChanged=�5      5      �� 5   
   $��10q�63   $��Sign In��6?   ��6   �� *SignInCommand+6S   �� 5   
   $��10q�63   $��Sign Up��6?   ��6   �� *SignUpCommand+6S   5      5      