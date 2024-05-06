import { GenreColumns, GenreRow, GenreService } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GenreDialog } from './GenreDialog';

@Decorators.registerClass('Serene_Movies_Task.Default.GenreGrid')
export class GenreGrid extends EntityGrid<GenreRow> {
    protected getColumnsKey() { return GenreColumns.columnsKey; }
    protected getDialogType() { return GenreDialog; }
    protected getRowDefinition() { return GenreRow; }
    protected getService() { return GenreService.baseUrl; }
}