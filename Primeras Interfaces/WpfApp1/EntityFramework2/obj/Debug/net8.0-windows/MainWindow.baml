   M S B A M L   `   `   `  ����J  FEntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EntityFrameworkEntityFramework  5   	        EntityFramework.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EntityFramework     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Nombre:��6   $
��Left=�6"   $��	10,10,0,0q�6=   $	��Top=�6P   �� 5   
   -   5        $��txtName��5   6   $
��Left=�6�   $��	71,14,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6  ��6E   �� *Nombre+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��6  �� 5   
   $��Edad:��6   $
��Left=�6    $��
201,10,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $��txtEdad��5   6   $
��Left=�6�   $��
257,14,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��34��6  ��6E   �� *Edad+$ PropertyChanged=�$
 True��$
 True��6  &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgPeople��5      $��5,67,193,34q�6$      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 69   �� 5   
   -   5        $��Añadir��5      $
��Left=�6"   $��
516,13,0,0q�6=   $	��Top=�6Q   $��82��6i   6t   �� 5   
   -   5        $��Eliminar��5      $
��Left=�6$   $��
621,13,0,0q�6?   $	��Top=�6S   $��62��6k   6v   �� 5   
   -   5        $��	Modificar��5      $
��Left=�6%   $��
712,13,0,0q�6@   $	��Top=�6T   $��66��6l   6w   �� 5   
   $��Nombre Macota:��6   $
��Left=�6)   $��
640,86,0,0q�6D   $	��Top=�6X    J� RenderTransformOrigin$ 0.503,0.625&�6p   $��30��6�   $	��105��6�   �� 5   
   -   5        $��txtNombreMascota��5      $�� ��6(   $
��Left=�63   $��640,121,0,0q�6N   $	��Top=�6c   $ 0.503,0.625&�6{   $��30��6�   $	��105��6�   �� 5   
   $��Tipo:��6   $
��Left=�6    $��640,156,0,0q�6;   $	��Top=�6P   $ 0.503,0.625&�6h   $��30��6�   $	��105��6�   �� 5   
   -   5        $��txtTipoMascota��5      $�� ��6&   $
��Left=�61   $��640,199,0,0q�6L   $	��Top=�6a   $ 0.503,0.625&�6y   $��30��6�   $	��105��6�   �� 5   
   -	   5        $��Mascota��5      $
��Left=�6#   $��
417,13,0,0q�6>   $	��Top=�6R   $��82��6j   6u   �� 5   
   $��Nombre Mascota:��6   $
��Left=�6*   $��	10,40,0,0q�6E   $	��Top=�6X   $	��134��6p   $ 0.5,0.5&�6|   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.356Q�6&   T� 5      5      5       �� 5!   
   -
   5         ��Name$ txtNameMascota��5!      $
��Left=�6*   $��
131,44,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5"   
   $
��Tipo��6   $
��Left=�6   $��
276,40,0,0q�6:   $	��Top=�6N   �� 5#   
   -   5        $ txtTypeMascota��5#      $
��Left=�6*   $��
332,44,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $��68��6�   5%      5&      