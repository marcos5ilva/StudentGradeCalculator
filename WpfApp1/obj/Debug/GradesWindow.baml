   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.GradesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  StudentsGrades��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ myGradesDataGrid��5
         AutoGenerateColumns . $��394,102,239,132q�6`   ��6H   �� 6`   �� 5   
   -   5         ��Name$ WriteGrades��5      $��
Add Grades��6&   $
��Left=�6;   $��
98,267,0,0q�6V   ���	#FF626B73$	��Top=�6�   $	��140��6�   ���	#FFF7EDED6�   �� 5   
   -   5         ��Name$ labelFristName��5      $��Frist Name:��6(   $
��Left=�6>   $��	82,30,0,0q�6Y   $	��Top=�6l   $��24��6�   $	��217��6�   �� 5   
   -   5        $ labelLastName��5      $��
Last Name:��6'   $
��Left=�6<   $��	82,59,0,0q�6W   $	��Top=�6j   $	��224��6�   �� 5   
   -   5        $ labelAssignment��5      $��Assignment:��6)   $
��Left=�6?   $��
82,102,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5        $ 
labelGrade��5      $��Grade��6$   $
��Left=�64   $��
82,144,0,0q�6O   $	��Top=�6c   �� 5   
   -   5         ��Name$ textBoxAssignment��5      $
��Left=�6-   $��23��6H   $��162,106,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��183��6�   �� 5   
   -   5        $ textBoxGrade��5      $
��Left=�6(   $��23��6C   $��162,148,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $��62��6�   5      5      