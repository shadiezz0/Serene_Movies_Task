﻿import { CheckTreeEditor, CheckTreeItem, Decorators, GridUtils } from "@serenity-is/corelib";
import { isEmptyOrNull } from "@serenity-is/corelib";
import { RoleRow } from "../";

@Decorators.registerEditor('Serene_Movies_Task.Administration.RoleCheckEditor')
export class RoleCheckEditor extends CheckTreeEditor<CheckTreeItem<any>, any> {

    private searchText: string;

    constructor(props: any) {
        super(props);
    }

    protected createToolbarExtensions() {
        super.createToolbarExtensions();

        GridUtils.addQuickSearchInputCustom(this.toolbar.element, (field, text) => {
            this.searchText = Select2.util.stripDiacritics(text || '').toUpperCase();
            this.view.setItems(this.view.getItems(), true);
        });
    }

    protected getButtons() {
        return [];
    }

    protected getTreeItems() {
        return RoleRow.getLookup().items.map(role => <CheckTreeItem<any>>{
            id: role.RoleId.toString(),
            text: role.RoleName
        });
    }

    protected onViewFilter(item) {
        return super.onViewFilter(item) &&
            (isEmptyOrNull(this.searchText) ||
                Select2.util.stripDiacritics(item.text || '')
                    .toUpperCase().indexOf(this.searchText) >= 0);
    }
}
