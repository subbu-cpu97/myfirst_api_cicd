resource "azurerm_container_registry" "acr" {
    name                = "f1sregistry${var.env_id}"
    location            = azurerm_resource_group.myf1rg.location
    resource_group_name = azurerm_resource_group.myf1rg.name
    sku                 = "Standard"
    admin_enabled       = true
    public_network_access_enabled = true
    
    tags = {
        environment = var.env_id
        src         = var.src_key
    }
  
}