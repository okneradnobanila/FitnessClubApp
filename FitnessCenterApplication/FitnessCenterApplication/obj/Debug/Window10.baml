   M S B A M L   `   `   `  ����S  OFitnessCenterApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FitnessCenterApplicationFitnessCenterApplication  5   	   '    !FitnessCenterApplication.Window10   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FitnessCenterApplication     5   	     � Title$  Фитнес-клуб��5   	   $	��500��6   $
��1100��6*    � 
ResizeMode$ CanMinimize=�67    � WindowStartupLocation$ CenterScreen=�6P   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ RoomsDataGrid��5
      $��Right=�6*   $	��175��6F   $��
0,236,50,0q�6S   $	��Top=�6g   $	��250��6      
IsReadOnly . 6�     5   
   -   5        $ ClassesDataGrid��5      $��Right=�6,   $	��159��6H   $��	0,41,50,0q�6U   $	��Top=�6h   $	��250��6�    . 6�     5   
   -   5        $ TrainersDataGrid��5      $	��175��6-   $��410,236,0,0q�6:   $	��Top=�6O    . $
��Left=�6y   $	��340��6�     5   
   -   5        $ AbonnementsDataGrid��5      $
��Left=�60   $	��175��6K   $��
50,236,0,0q�6X   $	��Top=�6l   $	��340��6�    . 6�     5   
   -   5        $ ScheduleDataGrid��5      $
��Left=�6-   $	��159��6H   $��	50,41,0,0q�6U   $	��Top=�6h   $	��700��6�    . 6�   �� 5   
   $��Расписание:��6   $
��Left=�6&   $��	50,10,0,0q�6A   $	��Top=�6T   �� 5   
   -   5         ��Name$ ReloadButton��5      $�� ��6'   $
��Left=�62   $��
525,10,0,0q�6M   $	��Top=�6a   $��25��6y   $��25��6�    J� RenderTransformOrigin$ 	0.48,1.84&�6�   ��5      �� 5       �� ImageSource$I CC:\Users\acer\source\repos\FitnessCenterApplication\reload_icon.ico��6    j� Stretch$ Uniform=�6o   5      �� 5   
   $��Абонементы:��6   $
��Left=�6&   $��
50,205,0,0q�6A   $	��Top=�6U   �� 5   
   $��Тренера:��6   $
��Left=�6#   $��410,205,0,0q�6>   $	��Top=�6S   �� 5   
   $��Занятия:��6   $
��Left=�6#   $��
794,10,0,0q�6>   $	��Top=�6R   �� 5   
   $��Помещения:��6   $
��Left=�6%   $��794,205,0,0q�6@   $	��Top=�6U   5      5      