#define script_zero_pad
// Adds a leading zero to numbers less than 10
if (argument0 < 10)
{
    return "0" + string(argument0);
}
else 
{
    return string(argument0);
}
