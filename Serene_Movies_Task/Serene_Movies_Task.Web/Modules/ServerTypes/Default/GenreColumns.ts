import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { GenreRow } from "./GenreRow";

export interface GenreColumns {
    GenreId: Column<GenreRow>;
    Name: Column<GenreRow>;
}

export class GenreColumns extends ColumnsBase<GenreRow> {
    static readonly columnsKey = 'Default.Genre';
    static readonly Fields = fieldsProxy<GenreColumns>();
}