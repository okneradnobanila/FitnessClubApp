   M S B A M L   `   `   `  ����S  OFitnessCenterApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FitnessCenterApplicationFitnessCenterApplication  5   	   &     FitnessCenterApplication.Window9   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FitnessCenterApplication     5   	     � Title$"  Администраторы��5   	   $	��400��6    $	��600��6-    � 
ResizeMode$ CanMinimize=�69    � WindowStartupLocation$ CenterScreen=�6R   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AdministratorsDataGrid��5
      $
��Left=�63   $	��250��6N   $��	50,50,0,0q�6[   $	��Top=�6n   $	��250��6�   �� 5   
   -   5         ��Name$ ID_tb��5      $��25��6!   $��
0,81,230,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U   $��Right=�6m   $��48��6�   �� 5   
   -   5        $ Login_tb��5      $��25��6$   $��
0,81,175,0q�60   $
 Wrap=�6D   $	��Top=�6X   $��Right=�6p   $��50��6�   �� 5   
   -   5        $ Password_tb��5      $��25��6'   $��
0,81,120,0q�63   $
 Wrap=�6G   $	��Top=�6[   $��Right=�6s   $��50��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $��Добавить��6$   $��Right=�67   $��	0,81,50,0q�6S   $	��Top=�6f   $��65��6~   $��25��6�   6�   �� 5   
   -   5        $ DeleteButton��5      $��Удалить��6'   $��
0,111,50,0q�69   $	��Top=�6M   $��25��6e   $��Right=�6�   $��65��6�    J� RenderTransformOrigin$ 0.492,-0.32&�6�   �� 5   
   -   5        $ ChangeButton��5      $��Изменить��6'   $��Right=�6:   $��0,141,167,0q�6V   $	��Top=�6k   $��65��6�   $��25��6�   6�   �� 5   
   -   5        $ ReloadButton��5      $�� ��6'   $
��Left=�62   $��
50,305,0,0q�6M   $	��Top=�6a   $��25��6y   $��25��6�   ��5      �� 5       �� ImageSource$I CC:\Users\acer\source\repos\FitnessCenterApplication\reload_icon.ico��6   	 j� Stretch$	 Uniform=�6o   5      �� 5   
   -	   5        $ 
ID_tb_Copy��5      $��25��6&   $��0,111,230,0q�62   $
 Wrap=�6G   $	��Top=�6[   $��Right=�6s   $��48��6�   �� 5   
   -
   5        $ Login_tb_Copy��5      $��25��6)   $��0,111,175,0q�65   $
 Wrap=�6J   $	��Top=�6^   $��Right=�6v   $��50��6�   �� 5   
   -   5        $ Password_tb_Copy��5      $��25��6,   $��0,111,120,0q�68   $
 Wrap=�6M   $	��Top=�6a   $��Right=�6y   $��50��6�   5      5      