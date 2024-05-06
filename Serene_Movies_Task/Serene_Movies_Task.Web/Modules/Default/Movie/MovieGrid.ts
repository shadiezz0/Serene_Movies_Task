import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/Default';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('Serene_Movies_Task.Default.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow> {
    protected getColumnsKey() { return MovieColumns.columnsKey; }
    protected getDialogType() { return MovieDialog; }
    protected getRowDefinition() { return MovieRow; }
    protected getService() { return MovieService.baseUrl; }
}