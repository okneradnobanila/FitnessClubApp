   M S B A M L   `   `   `  ����S  OFitnessCenterApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FitnessCenterApplicationFitnessCenterApplication  5   	   &     FitnessCenterApplication.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FitnessCenterApplication     5   	   -   5          �Name$  AttendanceRegisterWindow��5   	    � Title$&  Запись на занятия��5   	   $	��400��6#   $	��600��60    � 
ResizeMode$ CanMinimize=�6<    � WindowStartupLocation$ CenterScreen=�6U   .��5	      � .+�5   
   �� -   5         ��Name$ Delete_ID_lesson_TextBox��5      $��Right=�64   $��25��6P   $��0,142,175,0q�6\    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $��50��6�   �� 5   
   -   5        $ Delete_ID_card_TextBox��5      $��Right=�62   $��25��6N   $��0,142,120,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $��50��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AttendanceDataGrid��5      $
��Left=�6/   $	��250��6J   $��	50,50,0,0q�6W   $	��Top=�6j   $	��250��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $��Добавить��6$   $��Right=�67   $��	0,81,50,0q�6S   $	��Top=�6f   $��65��6~   $��25��6�   6�   �� 5   
   -   5        $ DeleteButton��5      $��Удалить��6'   $��
0,142,50,0q�69   $	��Top=�6M   $��25��6e   $��Right=�6�   $��65��6�   �� 5   
   -   5        $ ChangeButton��5      $��Изменить��6'   $��Right=�6:   $��
0,216,50,0q�6V   $	��Top=�6j   $��65��6�   $��25��6�   6�   �� 5   
   $/��)Добавить новые данные:��6   $��	0,50,56,0q�61   $	��Top=�6D   $��Right=�6\   $	��148��6x   �� 5   
   $"��Удалить данные:��6   $��0,111,103,0q�6*   $	��Top=�6?   $��Right=�6W   $	��101��6s   �� 5   
   -   5        $ ReloadButton��5      $�� ��6'   $
��Left=�62   $��
50,305,0,0q�6M   $	��Top=�6a   $��25��6y   $��25��6�   ��5      �� 5       �� ImageSource$I CC:\Users\acer\source\repos\FitnessCenterApplication\reload_icon.ico��6   	 j� Stretch$	 Uniform=�6o   5      �� 5   
   -	   5        $ Add_ID_lesson_TextBox��5      $��25��61   $��
0,81,175,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $��Right=�6}   $��50��6�   �� 5   
   -
   5        $ Add_ID_card_TextBox��5      $��25��6/   $��
0,81,120,0q�6;   $
 Wrap=�6O   $	��Top=�6c   $��Right=�6{   $��50��6�   �� 5   
   $$��Изменить данные:��6   $��
0,172,93,0q�6+   $	��Top=�6?   $��Right=�6W   $	��111��6s   �� 5   
   -   5        $  Original_ID_lesson_TextBox��5      $��25��66   $��0,203,175,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $��Right=�6�   $��50��6�   �� 5   
   -   5        $ Original_ID_card_TextBox��5      $��25��64   $��0,203,120,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $��Right=�6�   $��50��6�   �� 5   
   -   5        $ Changed_ID_lesson_TextBox��5      $��25��65   $��0,233,175,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $��Right=�6�   $��50��6�   �� 5   
   -   5        $ Changed_ID_card_TextBox��5      $��25��63   $��0,233,120,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $��Right=�6�   $��50��6�   �� 5   
   -   5        $ Add_ID_num_TextBox��5      $��25��6.   $��
0,81,230,0q�6:   $
 Wrap=�6N   $	��Top=�6b   $��Right=�6z   $��48��6�   �� 5    
   -   5        $ Delete_ID_num_TextBox��5       $��25��61   $��0,142,230,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $��Right=�6~   $��48��6�   �� 5!   
   -   5        $ Original_ID_num_TextBox��5!      $��25��63   $��0,203,230,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $��Right=�6�   $��48��6�   �� 5"   
   -   5        $ Changed_ID_num_TextBox��5"      $��25��62   $��0,233,230,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $��Right=�6   $��48��6�   �� 5#   
   -   5        $ 
InfoButton��5#      $�� ��6%   $��Right=�60   $��
0,305,50,0q�6L   $	��Top=�6`   $��25��6x   $��25��6�   
 J� RenderTransformOrigin$
 0.8,0.96&�6�   ��5$      �� 5%      $N HC:\Users\acer\source\repos\FitnessCenterApplication\exclamation_mark.ico��6   $	 Uniform=�6t   5'      5)      5*      