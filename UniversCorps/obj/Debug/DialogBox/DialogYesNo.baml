   M S B A M L   `   `   `  ����G  CUniversCorps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UniversCorps.DialogBoxUniversCorps.DialogBox  5   	   '    !UniversCorps.DialogBox.WinDeleteQ   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:UniversCorps.DialogBox     5   	     � Title$  Удаление��5   	      	WinDialog#��[  6    � 
ResizeMode$ NoResize=�6=   $	��410��6S   $	��410��6_   $	��410��6n   $	��150��5	   	   $	��150��6    � SizeToContent$ Height=�6&    � ShowInTaskbar .   � Topmost .  � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��64 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5#   
   ��   
BrdUpPanel#��[ 6   $��3��65   �� 5%   
     ImgLogo#��[ 6   $��3��61   $
��20px��6E   $
��20px��6S   �� 5'   
   -   5        $��BtnClose��5'        BtnDialogClose#��[ 6!   $��3��6I   6]   �� 5)   
   -   5        $��TxtTitle��5)        TxtTitle#��[ 6$   $��3��6F   $
��14pt(�6Z   �� 5-   
   -   5        $��TxtText��5-        TxtCore#��[ 6#   $��2��6D   $��1��6Q   $��Center=�6a   $	��Top=�6~   $
��14pt(�5.      $
��Wrap=�6$   �� 50   
   $��4��6   $��1��6"   $��Center=�62   $��Bottom=�6O    �� Orientation$ 
Horizontal=�6j   .+�53      �� -   5        $��BtnYes��53        BtnDialogMain#��[ 6#   $
��Да��6J   6W   �� 55      -   5        $��BtnNo��55      #��[ 6"   $��Нет��6I   $��10 0 0 0q�6W   6i   �� 57      -   5        $��BtnOk��57      #��[ 6"   $
��Ок��6I   6V   �� 59      -   5        $��	BtnCancel��59      #��[ 6&   $��Закрыть��6M   $��90��6_   $��10 0 0 0q�6j   6|   5;      5=      5?      