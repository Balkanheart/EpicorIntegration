Epicor Integration Module

TO DO:
Form Customization:
Make Item_Master, Bill_Master, Operations_Master configurable during runtime.  
Add toolbox form to turn on/off controls.

Manage Template Form:
Add/Delete/Edit Templates (both varieties)
View selected template

Item_CopyFrom:
View selected template values

Opr_CopyFrom:
View selected template values

OprTemplates:
Create DB
Create Form

Opr_Master:
Accept preload and fill table
Set condition and fields for (Labor Entry -> Qty Only)
Set condition and fields for (IF OP = SHEAR -> BACKFLUSH)

SubCon_Opr_Master:
Create form

Bill_Master:
Accept preload and fill table
Detect if added item has populated BOM
Default material additions to op10
Set condition and fields for (IF TYPE=M -> VIEWASASM = TRUE)


Item_Master:
Accept preload from template
Use template but retain original preload values
Set condition and fields for (IF TYPE=P -> SET LEAD TIME/SAFETY STOCK)
Set condition and fields for (IF TYPE=M -> USEREV = TRUE, QTYBEARING = TRUE)
Set condition and fields for (IF Frame of Flo-Machine -> TRACKSERIAL = TRUE)
Remove Volume
Only use Net Weight
Add all fields string.ToUpper()
On Warehouse Add -> Create set up to add subsequent Warehouse locations
Set Planner (BAL, ADNIK, FLO)

Serial Number:
Create form
Defaulto create serial mask, 'ELK', prefix with BAL or FLO

Config:
Grid Color schema changes

CheckIn_Master:
Create form
Approve and check in part

CheckOut_Master:
Create form
Check out part

Revision_Master:
Option to check out part

CheckIn_Master:
Create form


