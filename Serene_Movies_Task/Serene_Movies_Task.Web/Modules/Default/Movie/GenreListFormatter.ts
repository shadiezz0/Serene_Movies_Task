import { Decorators, Formatter, Lookup } from "@serenity-is/corelib";
import { FormatterContext } from "@serenity-is/sleekgrid";
import { GenreRow } from "@/ServerTypes/Default/GenreRow";

let lookup: Lookup<GenreRow>;
let promise: Promise<Lookup<GenreRow>>;

@Decorators.registerFormatter('MovieTutorial.GenreListFormatter')
export class GenreListFormatter implements Formatter {

    format(ctx: FormatterContext) {

        let idList = ctx.value as number[];
        if (!idList || !idList.length)
            return "";
        let byId = lookup?.itemById;
        if (byId) {
            return idList.map(x => {
                var z = byId[x];
                return ctx.escape(z == null ? x : z.Name);
            }).join(", ");
        }

        promise ??= GenreRow.getLookupAsync().then(l => {
            lookup = l;
            try {
                ctx.grid?.invalidate();
            }
            finally {
                lookup = null;
                promise = null;
            }
        }).catch(() => promise = null);

        return `<i class="fa fa-spinner"></i>`;
    }
}