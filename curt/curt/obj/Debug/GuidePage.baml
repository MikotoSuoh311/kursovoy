   M S B A M L   `   `   `  ����?  ;curt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:curtcurt  5          curt.GuidePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:curt     5        N� Title$  	GuidePage��5	      .��5      � $	��800��6   $	��450��6    � RowDefinitions 5   
   �� 5      $
��377* �6   �� 5      $	��73* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGridGuide��5         AutoGenerateColumns .     
IsReadOnly . $��2��6U   $��0,0,-79,-52q�6f    J� RenderTransformOrigin$ 0.931,0.958&�6{   $	��440��6�   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Номер Предмета��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6f   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *Subjects.Subjects_id+6t     5      $ Номер учителя��6%   $	 100 6e   	 6<   �� *Teachers.Teachers_id+6s     5      $ Дата сдачи��6%   $	 150 6V   	 69   �� *
DateYear+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      �� 5      .R�5      �� $ ��Редактировать��6%   6@   5      5      5      �� 5   
   $��Удалить��6   $��3��6#   $��Right=�60   6O   �� 5   
   $��Добавить��6   $��1��6$   $
��Left=�61   6O   5       5!      