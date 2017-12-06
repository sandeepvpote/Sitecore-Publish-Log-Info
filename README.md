# Sitecore-Publish-Log-Info

Sitecore publish log info helps to get details on who and what was published. This only consider's items that are not skipped i.e. those that are updated, created and deleted from master to web database or any publishing target.
Custom logger is impelmented with provision if not required can log in Siteore log's. Set Sitecore settings in config customlogger to false.


Following shall be the output-
24564 15:54:22 INFO  Publishing Details- Publish Mode - Full User- sitecore\admin published(Updated) Item Name- /sitecore/content/Home/New Person 1 Item Id- {996121BE-1F3C-40FD-A5E3-4D9ED4FB343E} from master to web
