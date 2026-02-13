// Práctica 1 - Uso de Git \\

Autor: Manuel Sánchez

P1. ¿Qué crees que significa la opción -n en el comando revert? -
-	Significa que Git revierta los cambios pero sin guardarlos
	automaticamente, así nos permite ver si queremos cambiar algo más antes de confirmarlo.

P2. ¿Qué cambios se han producido al ejecutar el comando reset? -
-	El puntero se mueve al commit anterior y vuelve al estado tal cual estaba anteriormente 
	borrando el historial posterior.

P3. ¿Qué diferencias observas entre revert y reset? -
-	Revert lo que hace es crear nuevos commit en el historial manteniendo lo anterior 
	mientras que el reset lo que hace es mover el repositorio al commit anterior o al que le
	indiques que quieres volver y elimina los posteriores, por lo que pierdes todo los cambios 
	posteriores.

P4. ¿Qué diferencias observas entre merge y rebase? -
	Merge combina las dos ramas creando un nuevo proceso y mantiene el historial, mientras que 
	rebase lo reescribe.