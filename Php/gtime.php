<?php


$ddate = date("Y-m-d");
$tdate = date("Hi");

$timestamp = strtotime($ddate);
$dayt = date( "l", $timestamp);
$daytime = date ("w", $timestamp);

if ($daytime==0)
{
die( "Logs Closed");
}
if ($daytime==1)
{
die( "Logs Closed");
}
if ($daytime==2)
{
die( "Logs Open");
}
if ($daytime==3)
{
die( "Logs Open");
}
if ($daytime==4)
{
die( "Logs Open");
}
if ($daytime==5 && $tdate -= 1100)
{
die( "Injury Time, Hurry!");
}
if ($daytime==5 && $tdate += 1101)
{
die( "Logs Closed");
}
if ($daytime==6)
{
die( "Logs Closed");
}
?>