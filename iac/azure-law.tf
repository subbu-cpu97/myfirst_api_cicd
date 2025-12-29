resource "azurerm_log_analytics_workspace" "law" {
    location = azurerm_resource_group.myf1rg.location
    name                = "f1slaw${var.env_id}"
    resource_group_name = azurerm_resource_group.myf1rg.name
    sku                 = "PerGB2018" 
    retention_in_days = 30
  
}